using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using vendorAssignment_04MananPatel5197.Helper;

namespace vendorAssignment_04MananPatel5197.Models.DBGenerated
{
    [ModelMetadataType(typeof(VendorMetaData))]
    public partial class Vendor
    {

    }
    public class VendorMetaData
    {
        [Required]
        [RegularExpression("(?i)^[a-z0-9 ]+$", ErrorMessage = "Name may not contain special characters.")]
        public string VendorName { get; set; }

        [Required]
        public string VendorAddress1 { get; set; }

        [Required]
        public string VendorCity { get; set; }

        [Required]
        [RegularExpression("[^,]*[a-zA-Z]{2}", ErrorMessage = "State must be two characters long.")]
        public string VendorState { get; set; }

        [Required]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        public string VendorZipCode { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Remote("CheckPhoneNumber", "Validation",HttpMethod ="POST", ErrorMessage = "Phone number already exists in the database.")]
        public string VendorPhone { get; set; }

        [Required]
        public int DefaultAccountNumber { get; set; }

        [Required]
        public int DefaultTermsId { get; set; }

    }
}
