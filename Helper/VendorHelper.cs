using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Models;

namespace vendorAssignment_04MananPatel5197.Helper
{
    public class VendorHelper
    {
public static List<NameGroupFilter> GetNameGroupFilters()
        {
            List<NameGroupFilter> nameGroupFilters = new List<NameGroupFilter>();
            nameGroupFilters.Add(new NameGroupFilter() { NameGroupId = 1, GroupName = "A - E", LowerLetter = 'A', UpperLetter = 'E' });
            nameGroupFilters.Add(new NameGroupFilter() { NameGroupId = 2, GroupName = "F - K", LowerLetter = 'F', UpperLetter = 'K' });
            nameGroupFilters.Add(new NameGroupFilter() { NameGroupId = 3, GroupName = "L - R", LowerLetter = 'L', UpperLetter = 'R' });
            nameGroupFilters.Add(new NameGroupFilter() { NameGroupId = 4, GroupName = "S - Z", LowerLetter = 'S', UpperLetter = 'Z' });
            return nameGroupFilters;
        }
    }
}
