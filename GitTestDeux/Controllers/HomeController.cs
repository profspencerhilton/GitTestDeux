using Microsoft.AspNetCore.Mvc;

namespace GitTestDeux.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
