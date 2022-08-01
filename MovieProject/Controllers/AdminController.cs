using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
