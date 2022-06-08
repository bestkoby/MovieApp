using Microsoft.AspNetCore.Mvc;

namespace Antra.MovieApp.WebMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
