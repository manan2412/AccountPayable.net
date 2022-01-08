using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Models.DBGenerated;

namespace vendorAssignment_04MananPatel5197.Models.ViewModel
{
    public class VendorRecordViewModel
    {
        public Vendor Vendor { get; set; }
        public List<Term> Terms { get; set; }
        public string filterId { get; set; }
        public List<GeneralLedgerAccount> GeneralLedgerAccounts { get; set; }
        public string ActionName { get; set; } 

    }
}
