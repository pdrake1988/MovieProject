using ApplicationCore.Contracts.Services;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class CastController : Controller
    {
        private readonly ICastServiceAsync castService;
        private readonly IMovieServiceAsync movieService;

        public CastController(ICastServiceAsync castService, IMovieServiceAsync movieService)
        {
            this.castService = castService;
            this.movieService = movieService;
        }

        [HttpGet]
        public async Task<ActionResult> Index(int? id)
        {
            if (id != null)
            {
                ViewBag.CastMember = castService.GetCastMemberByIdAsync((int)id);
            }
            ViewBag.Cast = await castService.GetAllCastMembersAsync();
            return View(await movieService.GetAllMoviesAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Index(CastModel cast)
        {
            await castService.CreateCastMember(cast);
            return RedirectToAction("Index");
        }
    }
}
