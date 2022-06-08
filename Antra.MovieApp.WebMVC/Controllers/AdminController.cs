using Microsoft.AspNetCore.Mvc;

namespace Antra.MovieApp.WebMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
