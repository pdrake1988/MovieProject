using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
