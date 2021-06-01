using DeliveryBookingMVC.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Services
{
    public class BookingManager:IRepo<Booking>
    {
        public DeliveryContext _context;
        public ILogger<BookingManager> _logger;
        public BookingManager(DeliveryContext context, ILogger<BookingManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(Booking t)
        {
            try
            {
                _context.Bookings.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }

        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetAll()
        {
            try
            {
                if ((_context.Bookings) == null)
                    return null;
                return _context.Bookings.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;

        }

        public int Login(Booking t)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Booking t)
        {
            throw new NotImplementedException();
        }
    }
}
