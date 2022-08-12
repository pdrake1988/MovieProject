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
        ICastServiceAsync castService;
        public MoviesController(IMovieServiceAsync movieService, 
            IGenreServiceAsync genreService, 
            ICastServiceAsync castService)
        {
            this.movieService = movieService;
            this.genreService = genreService;
            this.castService = castService;
        }
        [HttpGet]
        public async Task<ActionResult> Index(int? id)
        {   if (id != null)
            {
                ViewBag.Genre = await genreService.GetGenreById((int)id);
            }
            ViewBag.Genres = await genreService.GetAllGenresAsync();
            return View(await movieService.GetAllMoviesAsync());
        }
        [HttpGet]
        public async Task<ActionResult> MovieDetails(int id)
        {
            return View(await movieService.GetMovieByIdAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult> CreateGenre(Genre genre)
        {
            await genreService.CreateGenre(genre);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<ActionResult> CreateMovie(MovieModel movie)
        {
            await movieService.InsertMovieAsync(movie);
            return RedirectToAction("Index");
        }
    }
}
