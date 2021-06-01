﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Models
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryExecutive> DeliveryExecutives { get; set; }
        public DbSet<Booking> Bookings { get; set; }


    }
}
