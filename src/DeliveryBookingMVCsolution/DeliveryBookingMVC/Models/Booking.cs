using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Models
{
    public class Booking
    {
        [Key]
        [Display(Name ="Booking Id")]
        public int OrderID { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Executive Id")]
        [Required(ErrorMessage = "ExecutiveId cannot be empty!!")]
        public int ExecutiveId { get; set; }

        [Required(ErrorMessage = "Address cannot be empty!!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City cannot be empty!!")]
        public string City { get; set; }
        [Display(Name = "Pin Code")]
        [Required(ErrorMessage = "Pincode cannot be empty!!")]
        public int PinCode { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Enter your phone number!!")]
        //[MaxLength(10, ErrorMessage = "It exceeded the maximum value")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Should be a number!!")]
        public string Phone { get; set; }
        [Display(Name = "Date and Time of Pickup")]
        [Required(ErrorMessage = "Select Date and Time of Pickup!!")]
        public DateTime DateandTimeOfPickup { get; set; }

        [Display(Name = "Weight in kg")]
        [Required(ErrorMessage = "Enter the weight of package!!")]
        public int WeightOfPackage { get; set; }
        [Display(Name = "Price in Rs")]
        public float Price { get; set; } = 200;
        public string Status { get; set; }
    }
}
