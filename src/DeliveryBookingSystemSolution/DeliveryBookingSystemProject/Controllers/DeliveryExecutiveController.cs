using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemProject.Controllers
{
    public class DeliveryExecutiveController : Controller
    {
        // GET: DeliveryExecutiveController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeliveryExecutiveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeliveryExecutiveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeliveryExecutiveController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeliveryExecutiveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeliveryExecutiveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeliveryExecutiveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeliveryExecutiveController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
