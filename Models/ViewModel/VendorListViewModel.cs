using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Models.DBGenerated;

namespace vendorAssignment_04MananPatel5197.Models.ViewModel
{
    public class VendorListViewModel
    {
        public List<Vendor> Vendors { get; set; }
        public List<string> vendorFilterList {get;set;}
        public string SelectedNameFilter{get;set;}
        public string GetActiveNameFilter(string NameFilter)
        {
            return SelectedNameFilter == NameFilter ? "active" : "";
        }
        public List<NameGroupFilter> NameGroupFilters { get; set; }
        public int SelectedGroupNameFilterId { get; set; }
        public string GetActiveGroupNameFilter(int groupNameFilterId)
        {
            return SelectedGroupNameFilterId == groupNameFilterId ? "active" : "";
        }
    }
}
