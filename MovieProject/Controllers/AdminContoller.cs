using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class AdminContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
