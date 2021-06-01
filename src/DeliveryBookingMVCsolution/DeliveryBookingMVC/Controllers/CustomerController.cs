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
    public class CustomerController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public readonly ILogger<CustomerController> _logger;
        public readonly IRepo<Customer> _repo;
        public readonly IRepo<Booking> _repo1;
        public CustomerController(ILogger<CustomerController> logger, IRepo<Customer> repo, IRepo<Booking> repo1)
        {
            _logger = logger;
            _repo = repo;
            _repo1 = repo1;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Customer> customers = _repo.GetAll().ToList();
            return View(customers);
        }
        public IActionResult List()
        {
            List<Customer> customers = _repo.GetAll().ToList();
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customer.IsVerified = "null";
            _repo.Add(customer);
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            int id = _repo.Login(customer);


            if (id != 0)
            {
                TempData["CustomerId"] = id;
                return RedirectToAction("CustomerHomePage");
                //return RedirectToAction("Create","Bookings");
            }
            else
            {

                return RedirectToAction("Error");
            }
           
        }
        public IActionResult Edit(int id)
        {
            Customer c= _repo.Get(id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Edit(int id, Customer c)
        {
            _repo.Update(id, c);
            return RedirectToAction("List");
        }
        public IActionResult AcceptedList()
        {

            int id = Convert.ToInt32(TempData.Peek("CustomerId"));

            List<Booking> d = _repo1.GetAll().Where(a => a.CustomerId == id && a.Status == "accepted").ToList();
            if (d.Count() != 0)
            {
                return View(d); 
            }
            else if (d.Count() == 0)
            {
                return View("EmptyList");
            }
            return View();
        }
        public IActionResult RejectedList()
        {

            int id = Convert.ToInt32(TempData.Peek("CustomerId"));

            List<Booking> d = _repo1.GetAll().Where(a => a.CustomerId == id && a.Status == "rejected").ToList();
            if (d.Count() != 0)
            {
                return View(d);
            }
            else if (d.Count() == 0)
            {
                return View("EmptyList");
            }
            return View();
        }
        public IActionResult EmptyList()
        {
            return View();
        }
        public IActionResult CustomerHomePage()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Home");
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}
   