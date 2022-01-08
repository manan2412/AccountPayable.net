using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Models.DBGenerated;

namespace vendorAssignment_04MananPatel5197.Helper
{
    public class ValidationHelper
    {
      
        public static string PhoneNumberExists(apContext context, string vendorPhone)
        {
            string msg = "";

            // Checks to see that the phone number provided contains a value.
            if (!string.IsNullOrEmpty(vendorPhone))
            {
                // Strip out all of the digits out of the store phone number in order to simplify the comparison below.
                string numericPhoneNumber = new String(vendorPhone.Where(Char.IsDigit).ToArray());

                bool match = false;

                // Iterate through all the patient records to try and identify a matching phone number
                foreach (var vendor in context.Vendors.ToList())
                {
                    // Have to make sure that the patient's phone number has a value, otherwise an error will occur
                    if (vendor.VendorPhone != null)
                    {
                        // Strip out all of the digits to compare with passed phone number
                        string vendorPhoneNumber = new String(vendor.VendorPhone.Where(Char.IsDigit).ToArray());

                        // If a match is found, report it, otherwise, keep looping until all records have been searched through.
                        match = vendorPhoneNumber == numericPhoneNumber;

                        if (match)
                        {
                            break;
                        }
                    }
                }

                if (match)
                    msg = $"Phone number {vendorPhone} is already in use.";
            }
            return msg;
        }
    }
}
