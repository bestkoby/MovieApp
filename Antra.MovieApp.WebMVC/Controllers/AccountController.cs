using Microsoft.AspNetCore.Mvc;

namespace Antra.MovieApp.WebMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
