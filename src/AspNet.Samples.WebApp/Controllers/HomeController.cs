using AspNet.Samples.ClassLibrary;

using Microsoft.AspNetCore.Mvc;

namespace AspNet.Samples.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = Hello.World();

            return View();
        }

        public IActionResult Error() => View();
    }
}
