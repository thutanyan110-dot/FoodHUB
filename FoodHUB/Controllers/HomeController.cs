using System.Web.Mvc;

namespace FoodHUB.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}
