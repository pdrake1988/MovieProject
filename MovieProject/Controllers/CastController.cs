using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class CastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
