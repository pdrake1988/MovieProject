using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.GenreSelect = new SelectList(await genreService.GetAllGenresAsync(), "Id", "Name");
            ViewBag.Genres = await genreService.GetAllGenresAsync();
            return View(await movieService.GetAllMoviesAsync());
        }
        [HttpGet]
        public async Task<ActionResult> MovieDetails(int id)
        {
            var movie = await movieService.GetMovieByIdAsync(id);
            return View(movie);
        }
        public async Task<ActionResult> CreateGenre(Genre genre)
        {
            await genreService.CreateGenre(genre);
            return RedirectToAction("Index");
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
