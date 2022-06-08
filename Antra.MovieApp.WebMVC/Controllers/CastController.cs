using Microsoft.AspNetCore.Mvc;

namespace Antra.MovieApp.WebMVC.Controllers
{
    public class CastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
