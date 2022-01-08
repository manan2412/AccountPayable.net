using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Models.DBGenerated;

namespace vendorAssignment_04MananPatel5197.Models.ViewModel
{
    public class VendorInvoicesViewModel
    {

        public string VendorName { get; set; }
        public string VendorAdd { get; set; }
        public string VendorTerm { get; set; }
        public int NameGroupFilterId { get; set; }
        public NameGroupFilter nameGroupFilter { get; set; }
        public List<Invoice> invoices { get; set; }
        public Invoice SelectedInvoice { get; set; }
        public int SelectedInvoiceId { get; set; }
        public List<InvoiceLineItem> InvoiceLineItems { get; set; }
        public int generalLedgerId { get; set; }
        public GeneralLedgerAccount generalLedgerAccount { get; set; }
        public string GetActiveInvoice(int invoiceId)
        {
            return SelectedInvoiceId == invoiceId ? "active" : string.Empty;
        }

    }
}
    
