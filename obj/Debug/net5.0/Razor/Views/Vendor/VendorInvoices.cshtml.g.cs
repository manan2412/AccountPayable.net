#pragma checksum "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c9c9aa540ebefe86db1f6c9b072989d54bb1ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_VendorInvoices), @"mvc.1.0.view", @"/Views/Vendor/VendorInvoices.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\_ViewImports.cshtml"
using vendorAssignment_04MananPatel5197;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\_ViewImports.cshtml"
using vendorAssignment_04MananPatel5197.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\_ViewImports.cshtml"
using vendorAssignment_04MananPatel5197.Models.DBGenerated;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\_ViewImports.cshtml"
using vendorAssignment_04MananPatel5197.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9c9aa540ebefe86db1f6c9b072989d54bb1ab6", @"/Views/Vendor/VendorInvoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed7d62971d9322939009d4a2240631dcfe0b3e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendor_VendorInvoices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VendorInvoicesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VendorList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right col-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-nameGroupFilterId", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VendorInvoicesList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewInvoiceLineItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h4 class=\"text-left col-8\">Invoice for ");
#nullable restore
#line 5 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                           Write(Model.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
         if (Model.NameGroupFilterId != null && Model.NameGroupFilterId != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9c9aa540ebefe86db1f6c9b072989d54bb1ab66747", async() => {
                WriteLiteral("Return to ");
#nullable restore
#line 9 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                                                                                                                      Write(Model.nameGroupFilter.GroupName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Vendors");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-nameGroupFilterId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                                        WriteLiteral(Model.nameGroupFilter.NameGroupId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nameGroupFilterId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-nameGroupFilterId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nameGroupFilterId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9c9aa540ebefe86db1f6c9b072989d54bb1ab69841", async() => {
                WriteLiteral("Return to Vendor List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-nameGroupFilterId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nameGroupFilterId"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
         if (Model.VendorAdd != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span style=\"color:gray;\" class=\"text-left col-7\">Address: ");
#nullable restore
#line 20 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                                                  Write(Model.VendorAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 21 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
         if (Model.VendorTerm != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span style=\"color:gray;\" class=\"text-right col-5\">Terms: ");
#nullable restore
#line 24 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                                                 Write(Model.VendorTerm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 25 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 27 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
     if (Model.invoices.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row pt-5\">\r\n            <div class=\"col-3\">\r\n                <h4 class=\"font-weight-bold\">Invoices:</h4>\r\n                <ul class=\"nav nav-pills flex-column\">\r\n");
#nullable restore
#line 33 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                     foreach (var invoice in Model.invoices)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9c9aa540ebefe86db1f6c9b072989d54bb1ab614698", async() => {
                WriteLiteral("Invoice: ");
#nullable restore
#line 39 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                                                                               Write(invoice.InvoiceNumber);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-invoiceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                        WriteLiteral(invoice.InvoiceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["invoiceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-invoiceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["invoiceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                       WriteLiteral(Model.NameGroupFilterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filterId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filterId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filterId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1577, "nav-link", 1577, 8, true);
#nullable restore
#line 39 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
AddHtmlAttributeValue(" ", 1585, Model.GetActiveInvoice(invoice.InvoiceId), 1586, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 41 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"col-3\"></div>\r\n            <div class=\"col-6\">\r\n");
#nullable restore
#line 46 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                 if (Model.SelectedInvoice != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"font-weight-bold\">Line Items for Invoice ");
#nullable restore
#line 48 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                                                   Write(Model.SelectedInvoice.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral(@"                    <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Description</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 58 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                             foreach (InvoiceLineItem lineItem in Model.InvoiceLineItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 61 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                   Write(lineItem.LineItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 62 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                   Write(lineItem.LineItemAmount.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 64 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                             if (Model.InvoiceLineItems.Count() > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>Total</td>\r\n                                    <td>");
#nullable restore
#line 69 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                   Write(Model.SelectedInvoice.InvoiceTotal.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9c9aa540ebefe86db1f6c9b072989d54bb1ab622855", async() => {
                WriteLiteral(@"

                        <div class=""row pb-2"">
                            <label class=""col-3"">Description:</label>
                            <input type=""text"" name=""description"" class=""col-9 form-control"" />
                            <span class=""text-danger""></span>
                        </div>

                        <div class=""row pb-2"">
                            <label class=""col-3"">Amount:</label>
                            <input type=""text"" name=""amount"" class=""col-9 form-control"" />
                            <span class=""text-danger""></span>
                        </div>

                        <input class=""btn btn-outline-info"" type=""submit"" value=""Add new line item"" />
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-generalLedgerId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                         WriteLiteral(Model.generalLedgerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["generalLedgerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-generalLedgerId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["generalLedgerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                  WriteLiteral(Model.SelectedInvoice.VendorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["vendorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vendorId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["vendorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                   WriteLiteral(Model.NameGroupFilterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["filterId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filterId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["filterId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                   WriteLiteral(Model.SelectedInvoiceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["invoiceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-invoiceId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["invoiceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 101 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"jumbotron pt-5 text-center\">\r\n            <h2>No invoices for vendors: ");
#nullable restore
#line 105 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
                                    Write(Model.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n");
#nullable restore
#line 107 "C:\Users\manan\OneDrive\Documents\PROG2230\Assignment-04\vendorAssignment-04MananPatel5197\Views\Vendor\VendorInvoices.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendorInvoicesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
