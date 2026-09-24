using System.Web.Mvc;

namespace FoodHUB.Controllers
{
    public class AboutController : Controller
    {
        // GET: /About
        public ActionResult Index()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
