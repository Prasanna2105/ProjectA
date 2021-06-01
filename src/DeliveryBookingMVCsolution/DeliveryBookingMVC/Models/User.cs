using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Models
{
    public class User
    {
        [Display(Name="User Name")]
        public string UserName { get; set; }
        public string Password { get; set; }
       // public string UserType { get; set; }
    }
}
