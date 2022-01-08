using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Helper;
using vendorAssignment_04MananPatel5197.Models;
using vendorAssignment_04MananPatel5197.Models.DBGenerated;
using vendorAssignment_04MananPatel5197.Models.ViewModel;

namespace vendorAssignment_04MananPatel5197.Controllers
{
    public class VendorController : Controller
    {
        private apContext context;
        private string filterIdKey = "SelectedFilterIdKey";
        public VendorController(apContext vendorContext)
        {
            context = vendorContext;
        }
        
        [HttpGet]
        public IActionResult VendorList(bool filterExplicit = false, int nameGroupFilterId = 1)
        {
            if (filterExplicit)
            {
                HttpContext.Response.Cookies.Delete(filterIdKey);
            }
            else
            {
                if (HttpContext.Request.Cookies[filterIdKey] != null)
                {
                    nameGroupFilterId = int.Parse(HttpContext.Request.Cookies[filterIdKey]);
                }
            }
            var vendorList = new List<Vendor>();
            vendorList = context.Vendors.ToList();

            List<string> nameFilterList = vendorList.Select(s => s.VendorName).Distinct().ToList();
            List<NameGroupFilter> nameGroupFilters = VendorHelper.GetNameGroupFilters();

            nameGroupFilters.Insert(0, new NameGroupFilter() { NameGroupId = 0, GroupName = "All", LowerLetter = 'A', UpperLetter = 'Z' });
            /*nameFilterList.Insert(0, "All");
            var selectedNameFilter = "";

            if(selectedNameFilter != "All")
            {
                vendorList = vendorList.Where(w => w.VendorName == selectedNameFilter).ToList();
            }
*/
            var selectedNameGroupFilterId = nameGroupFilterId;
         
            
            if(selectedNameGroupFilterId != 0)
            {
                var selectedNameGroup = nameGroupFilters
                    .Where(w => w.NameGroupId == selectedNameGroupFilterId)
                    .FirstOrDefault();
                vendorList = vendorList
                    .Where(w => w.VendorName[0] >= selectedNameGroup.LowerLetter
                            && w.VendorName[0] <= selectedNameGroup.UpperLetter)
                    .OrderBy(ob => ob.VendorName)
                    .ToList();
            }
            vendorList = vendorList.Where(w => w.IsDeleted == false).ToList();

            VendorListViewModel vlvm = new VendorListViewModel()
            {
                Vendors = vendorList,
                
                vendorFilterList = nameFilterList,
               /* SelectedNameFilter = selectedNameFilter,*/
                SelectedGroupNameFilterId = selectedNameGroupFilterId,
                NameGroupFilters = nameGroupFilters
               
            };
            return View(vlvm);
        }
        public IActionResult SoftDelete(int vendorId)
        {
            var vendorRecord = context.Vendors.Find(vendorId);
            if(vendorRecord != null)
            {
                vendorRecord.IsDeleted = true;
                context.Update(vendorRecord);
                context.SaveChanges();
                TempData["DeleteVendorName"] = vendorRecord.VendorName;
                TempData["VendorID"] = vendorRecord.VendorId;

            }
            return RedirectToAction("VendorList");


        }
        public IActionResult UndoDelete(int vendorID)
        {
            var vendorDeletedRecord = context.Vendors.Find(vendorID);
            if (vendorDeletedRecord != null)
            {
                vendorDeletedRecord.IsDeleted = false;
                context.Update(vendorDeletedRecord);
                context.SaveChanges();
            }
            return RedirectToAction("VendorList");


        }
        [HttpGet]
        public IActionResult VendorRecord(string actionType, int filterId, int vendorID)
        {
            HttpContext.Response.Cookies.Append(filterIdKey, filterId.ToString());
            Vendor vendor = null;
            if (actionType =="Add")
            {
                vendor = new Vendor();
            }
            else if (actionType == "Edit")
            {
                vendor = context.Vendors.Find(vendorID);
            }
            VendorRecordViewModel vrvm = new VendorRecordViewModel()
            {
                Vendor = vendor,
                ActionName = actionType,
                Terms = context.Terms.ToList(),
            GeneralLedgerAccounts = context.GeneralLedgerAccounts.ToList()
        };
            ModelState.AddModelError("", "");
            return View("VendorRecord",vrvm);
        }
        [HttpPost]
        public IActionResult VendorRecord(Vendor vendor, string actionName)
        {
            
            
            if(ModelState.IsValid)
            {   //Add
                if (vendor.VendorId == 0)
                {
                    context.Vendors.Add(vendor);
                    context.SaveChanges();
                }
                //Edit
                else
                {
                    context.Update(vendor);
                    context.SaveChanges();
                }
                return RedirectToAction("VendorList");
            }
            else
            {

                ModelState.AddModelError("", "There are errors in the form below.");
                VendorRecordViewModel vrvm = new VendorRecordViewModel()
                { 
                    Vendor = vendor,
                    ActionName = actionName,
                    Terms = context.Terms.ToList(),
                    GeneralLedgerAccounts = context.GeneralLedgerAccounts.ToList()
                };

                return View(vrvm);
            }
        }
        [HttpGet]
        public IActionResult VendorInvoicesList(int vendorId, int filterId, int invoiceId = 0)
        {
            Vendor vendor = null;
            
            var vendors = context.Vendors.Include(i => i.Invoices).ThenInclude(ti => ti.InvoiceLineItems);
            vendor = vendors.Where(w => w.VendorId == vendorId).FirstOrDefault();
            var term = context.Terms.Find(vendor.DefaultTermsId);
            var selectedNameGroupFilterId = filterId;
            List<NameGroupFilter> nameGroupFilters = VendorHelper.GetNameGroupFilters();
            var selectedNameGroup = new NameGroupFilter() ;
            var invoices = vendor.Invoices.ToList();
            if (selectedNameGroupFilterId != 0)
            {
               selectedNameGroup = nameGroupFilters
                    .Where(w => w.NameGroupId == selectedNameGroupFilterId)
                    .FirstOrDefault();
            }
            var selectedInvoiceId = 0;
            Invoice selectedInvoice = null;
            List<InvoiceLineItem> invoiceLineItems = new List<InvoiceLineItem>();

            // Check to see if the user has selected a different prescription from the list populated in the view page, if so,
            // load up the information for that prescrition, otherwise, fetch the first prescription record in the list and load
            // its information in the table.
            if (invoiceId != 0)
            {
                selectedInvoiceId = invoiceId;
                selectedInvoice = invoices.Where(w => w.InvoiceId == selectedInvoiceId).FirstOrDefault();
                invoiceLineItems = selectedInvoice.InvoiceLineItems.ToList();
            }
            else if (invoices.Count() > 0)
            {
                selectedInvoiceId = invoices.First().InvoiceId;
                selectedInvoice = invoices.First();
                invoiceLineItems = selectedInvoice.InvoiceLineItems.ToList();
            }
            VendorInvoicesViewModel vivm = new VendorInvoicesViewModel()
            {
                VendorName = vendor.VendorName,
                VendorAdd = vendor.VendorAddress1,
                VendorTerm = term.TermsDueDays.ToString(),
                NameGroupFilterId = selectedNameGroupFilterId,
                nameGroupFilter = selectedNameGroup,
                invoices = invoices,
                SelectedInvoice = selectedInvoice,
                SelectedInvoiceId = selectedInvoiceId,
                InvoiceLineItems = invoiceLineItems
            };
            return View("VendorInvoices",vivm);
        }


        [HttpPost]
        public IActionResult AddNewInvoiceLineItem(int vendorId, int filterId, int invoiceId, string description, string amount)
        {
            // Retrieve the last prescription line item sequence in order to be able to increment it by 1
            // in order to be able to add a new prescription line item for the selected prescription.
            var lastPrescriptionSequence = context.InvoiceLineItems
                .Where(w => w.InvoiceId == invoiceId)
                .OrderByDescending(obd => obd.InvoiceSequence)
                .Select(s => s.InvoiceSequence)
                .FirstOrDefault();

            lastPrescriptionSequence += 1;

            /*var generalLedgerId = context.InvoiceLineItems
                .Where(w => w.InvoiceId == invoiceId)
                .OrderByDescending(obd => obd.AccountNumber)
                .Select(s => s.AccountNumber)
                .FirstOrDefault();*/

            // Create a temporary prescription line item record and prepare it with
            // the fields passed from the form on the view page and add it as a new
            // record to the database.
            GeneralLedgerAccount generalLedgerAccount = new GeneralLedgerAccount()
            {
                AccountDescription = description
            };
            context.GeneralLedgerAccounts.Add(generalLedgerAccount);
        
            var generalLedgerId = context.GeneralLedgerAccounts
                .Where(w => w.AccountDescription == description)
                .Select(s => s.AccountNumber)
                .FirstOrDefault();
            InvoiceLineItem lineItem = new InvoiceLineItem()
            {
                InvoiceId = invoiceId,
                InvoiceSequence = lastPrescriptionSequence,
                AccountNumber = generalLedgerId,
                LineItemAmount = decimal.Parse(amount),
                LineItemDescription = description
            };

            context.InvoiceLineItems.Add(lineItem);

            // Update the associated prescription record with the newly calculated total
            // from the pre-exisiting stored total amount in the prescription record and
            // by adding the new amount as passed by the submitted form.
            var invoice = context.Invoices.Find(invoiceId);
            invoice.InvoiceTotal += decimal.Parse(amount);

            context.Invoices.Update(invoice);
            context.SaveChanges();

            return RedirectToAction("VendorInvoicesList", new { vendorId, invoiceId, filterId });
        }
    }
}
