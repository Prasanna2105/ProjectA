using DeliveryBookingMVC.Models;
using DeliveryBookingMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Controllers
{
    public class AdminController : Controller
    {
        public readonly ILogger<AdminController> _logger;
        public readonly IRepo<Customer> _repoCustomer;
        public readonly IRepo<DeliveryExecutive> _repoExecutive;
        public AdminController(ILogger<AdminController> logger, IRepo<Customer> repoCustomer, IRepo<DeliveryExecutive> repoExecutive)
        {
            _logger = logger;
            _repoCustomer = repoCustomer;
            _repoExecutive = repoExecutive;
        }
        //public IActionResult AdminLogin(User u)
        //{ 
        //    if(u.UserName == "admin" && u.Password == "admin")
        //    {
        //        return RedirectToAction("CustomerDetails");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index","Customer");
        //    }   
        //}
        //public IActionResult CustomerDetails()
        //{
        //    List<Customer> customers = _repoCustomer.GetAll().ToList();
        //    if (customers != null)
        //    {
        //        return View(customers);
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        //public IActionResult ExecutiveDetails()
        //{
        //    List<DeliveryExecutive> Executives = _repoExecutive.GetAll().ToList();
        //    if (Executives != null)
        //    {
        //        return View(Executives);
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User u)
        {
            if (u.UserName == "Admin" && u.Password == "1234")
            {
                return RedirectToAction("AdminHomePage");
            }
            else
            {
                return View();
            }

        }
        public IActionResult AdminHomePage()
        {
            

            return View();
        }
     
        public ActionResult Home()
        {
            return View();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

    }
}
