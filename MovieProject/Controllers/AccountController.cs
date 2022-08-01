using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
