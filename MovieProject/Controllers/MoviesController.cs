using ApplicationCore.Contracts.Services;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class MoviesController : Controller
    {
        IMovieServiceAsync movieService;
        IGenreServiceAsync genreService;
        public MoviesController(IMovieServiceAsync movieService, IGenreServiceAsync genreService)
        {
            this.movieService = movieService;
            this.genreService = genreService;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            ViewBag.Genres = await genreService.GetAllGenresAsync();
            return View(await movieService.GetAllMoviesAsync());
        }
        [HttpGet]
        public async Task<ActionResult> MovieDetails(int id)
        {
            var movie = await movieService.GetMovieByIdAsync(id);
            return View(movie);
        }
        [HttpPost]
        public async Task<ActionResult> CreateMovie(MovieModel movie)
        {
            if (ModelState.IsValid)
            {
                await movieService.InsertMovieAsync(movie);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
