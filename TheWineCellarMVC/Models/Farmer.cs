using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    public class Farmer
    {
        // Table containing the farmer details -> Entered into DB
        public int FarmerId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Enter the Farmers First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Enter the Farmers Last Name")]
        public string LastName { get; set; }

        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Enter the Farmers Contact Number")]
        public long ContactNumber { get; set; }
    }
}
