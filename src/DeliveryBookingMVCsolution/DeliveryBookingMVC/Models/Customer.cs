using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        
        [Required(ErrorMessage = "Enter your Name!!")]
        public string Name { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Enter your User Name!!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password cannot be empty!!")]
        public string Password { get; set; }

        public int Age { get; set; }
        [Display(Name = "Phone Number")]
        [StringLength(maximumLength : 10, MinimumLength = 10, ErrorMessage = "Phone number should be 10 digits")]

        //[MaxLength(10, ErrorMessage = "It exceeded the maximum value")]
       //[RegularExpression("^[0-9]*$", ErrorMessage = "Should be a number!!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address cannot be empty!!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City cannot be empty!!")]
        public string City { get; set; }
        [Display(Name = "Pin Code")]
        [Required(ErrorMessage = "Enter Pincode!!")]
        public int PinCode { get; set; }

        public string IsVerified { get; set; }
    }
}
