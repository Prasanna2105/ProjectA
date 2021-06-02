using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Models
{
    public class DeliveryExecutive
    {
        [Key]
        [Display(Name = "Executive Id")]
        public int ExecutiveId { get; set; }
        [Required(ErrorMessage = "Enter your Name!!")]
        [Display(Name = "Executive Name")]
        public string Name { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Enter your User Name!!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password cannot be empty!!")]
        public string Password { get; set; }
        [Required]
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years!!")]
        public int Age { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number cannot be empty!!")]
        [MaxLength(10, ErrorMessage = "It exceeded the maximum value")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Should be a number!!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address cannot be empty!!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City cannot be empty!!")]
        public string City { get; set; }
        [Display(Name = "Pin Code")]
        [Required]
        [Range(100000, 999999, ErrorMessage = "pincode must be 6 digits")]
        public int PinCode { get; set; }
        [Display(Name = "Is Verified")]
        public string IsVerified { get; set; }
    }
}
