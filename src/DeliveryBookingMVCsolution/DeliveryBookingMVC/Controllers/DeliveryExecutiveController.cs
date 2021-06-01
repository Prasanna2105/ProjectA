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
    public class DeliveryExecutiveController : Controller
    {
        public readonly ILogger<DeliveryExecutiveController> _logger;
        public readonly IRepo<DeliveryExecutive> _repo;
        public readonly IRepo<Booking> _repo1;
        public DeliveryExecutiveController(ILogger<DeliveryExecutiveController> logger, IRepo<DeliveryExecutive> repo,IRepo<Booking> repo1)
        {
            _logger = logger;
            _repo = repo;
            _repo1 = repo1;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<DeliveryExecutive> deliveryExecutives = _repo.GetAll().ToList();
            return View(deliveryExecutives);
        }
        public IActionResult List()
        {
            List<DeliveryExecutive> deliveryExecutives = _repo.GetAll().ToList();
            return View(deliveryExecutives);
        }
        public IActionResult ExecutiveList()
        {
            List<DeliveryExecutive> deliveryExecutives = _repo.GetAll().Where(a => a.IsVerified == "yes").ToList();
            return View(deliveryExecutives);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DeliveryExecutive deliveryExecutive)
        {
            deliveryExecutive.IsVerified = "null";
            _repo.Add(deliveryExecutive);
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(DeliveryExecutive deliveryExecutive)
        {
           int id = _repo.Login(deliveryExecutive);
            try
            {
                if (id != 0)
                {
                    TempData["ExecutiveId"] = id;
                    return RedirectToAction("ExecutiveHomePage");
                }
            }
            catch (Exception e)

            {
                _logger.LogDebug(e.Message);

            }
            return RedirectToAction("Error");
        }
        public IActionResult RequestsPending()
        {
            
            int id = Convert.ToInt32(TempData.Peek("ExecutiveId"));

            List<Booking> d = _repo1.GetAll().Where(a => a.ExecutiveId == id && a.Status=="requested").ToList();
            if (d.Count() != 0)
            {
                return View(d);
            }
            else if (d.Count() == 0)
            {
                return View("NoPending");
            }
            return View();
        }
        public IActionResult NoPending()
        {
            return View();
        }
        public IActionResult WorkDone()
        {

            int id = Convert.ToInt32(TempData.Peek("ExecutiveId"));

            List<Booking> d = _repo1.GetAll().Where(a => a.ExecutiveId == id && a.Status == "accepted").ToList();
            if (d.Count() != 0)
            {
                return View(d);
            }
            else if (d.Count() == 0)
            {
                return View("NotDone");
            }
            return View();
        }
        public IActionResult NotDone()
        {
            return View();
        }
    
        public ActionResult ExecutiveHomePage()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            DeliveryExecutive delivery = _repo.Get(id);
            return View(delivery);
        }
        [HttpPost]
        public IActionResult Edit(int id, DeliveryExecutive delivery)
        {
            _repo.Update(id, delivery);
            return RedirectToAction("List");
        }
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }
    }
}
