using System.Web.Mvc;
using FoodHUB.Models;

namespace FoodHUB.Controllers
{
    public class ContactController : Controller
    {
        // GET: /Contact
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Contact Us";
            return View(new ContactMessage());
        }

        // POST: /Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactMessage model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Title = "Contact Us";
                return View(model);
            }

            // In a production app you would send an email or save to a database here.
            // For demo purposes we simply pass the submission on to the Thanks page.
            TempData["ContactName"] = model.Name;
            return RedirectToAction("Thanks");
        }

        // GET: /Contact/Thanks
        public ActionResult Thanks()
        {
            ViewBag.Title = "Message Sent";
            return View();
        }
    }
}
