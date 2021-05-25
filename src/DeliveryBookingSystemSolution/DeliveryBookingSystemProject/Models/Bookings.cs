using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemProject.Models
{
    public class Bookings
    {
        [Key]
        public int OrderID { get; set; }
        
        public int CustomerId { get; set; }
        
        public int ExecutiveId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime TimeOfPickup { get; set; }
        public string Status { get; set; }
        public int WeightOfPackage { get; set; }
        public float Price { get; set; }
    }
}
