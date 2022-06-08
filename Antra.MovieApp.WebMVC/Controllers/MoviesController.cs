using Microsoft.AspNetCore.Mvc;

namespace Antra.MovieApp.WebMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
