using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Helper;
using vendorAssignment_04MananPatel5197.Models.DBGenerated;

namespace vendorAssignment_04MananPatel5197.Controllers
{
    public class ValidationController : Controller
    {
        private apContext context;
        public ValidationController(apContext vendorDBContext)
        {
            context = vendorDBContext;
        }
        [HttpPost]
        public JsonResult CheckPhoneNumber(Vendor vendor)
        {
            // Call the validation helper class and execute its static method PhoneNumberExists to see there is a phone number match or not.
            string msg = ValidationHelper.PhoneNumberExists(context, vendor.VendorPhone);

            // If there is no message returned from the method above, the phone number is unique and there is no validation errors, otherwise, return the error
            // message returned from the method call above.
            if (string.IsNullOrEmpty(msg))
            {
                TempData["okPhoneNumber"] = true;
                return Json(true);
            }
            else
            {
                return Json(msg);
            }
        }
    }
}
