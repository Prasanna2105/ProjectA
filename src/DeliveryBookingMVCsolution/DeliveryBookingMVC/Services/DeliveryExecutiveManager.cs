using DeliveryBookingMVC.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Services
{
    public class DeliveryExecutiveManager :IRepo<DeliveryExecutive>
    {
        public DeliveryContext _context;
        public ILogger<DeliveryExecutiveManager> _logger;
        public DeliveryExecutiveManager(DeliveryContext context, ILogger<DeliveryExecutiveManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(DeliveryExecutive t)
        {
            try
            {
                _context.DeliveryExecutives.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }

        public IEnumerable<DeliveryExecutive> GetAll()
        {
            try
            {
                if ((_context.DeliveryExecutives) == null)
                    return null;
                return _context.DeliveryExecutives.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;

        }

        public int Login(DeliveryExecutive t)
        {
            DeliveryExecutive obj = _context.DeliveryExecutives.Where(i => i.UserName.Equals(t.UserName) && i.Password.Equals(t.Password) && i.IsVerified.Equals("yes")).FirstOrDefault();
            try
            {
                if (obj != null)
                {
                    return obj.ExecutiveId;
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return 0;
        }
        public DeliveryExecutive Get(int id)
        {
            try
            {
                DeliveryExecutive delivery = _context.DeliveryExecutives.FirstOrDefault(a => a.ExecutiveId == id);
                return delivery;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
        public void Update(int id, DeliveryExecutive t)
        {
            DeliveryExecutive delivery = Get(id);
            if (delivery != null)
            {
                delivery.IsVerified = t.IsVerified;
            }
            _context.SaveChanges();

        }
    }
}
