using System;
using System.Web.Mvc;
using FoodHUB.Models;

namespace FoodHUB.Controllers
{
    public class ReservationController : Controller
    {
        // GET: /Reservation
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Make a Reservation";
            return View(new Reservation { Date = DateTime.Today.AddDays(1) });
        }

        // POST: /Reservation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Reservation model)
        {
            if (model.Date != default(DateTime) && model.Date < DateTime.Today)
            {
                ModelState.AddModelError("Date", "Reservation date must be today or in the future.");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Title = "Make a Reservation";
                return View(model);
            }

            // In production: persist to database / send confirmation email.
            return RedirectToAction("Confirm", model);
        }

        // GET: /Reservation/Confirm
        public ActionResult Confirm(Reservation model)
        {
            ViewBag.Title = "Reservation Confirmed";
            return View(model);
        }
    }
}
