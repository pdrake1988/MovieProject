
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieServiceAsync : IMovieServiceAsync
    {

        IMovieRepositoryAsync movieRepository;
        IGenreServiceAsync genreService;
        public MovieServiceAsync(IMovieRepositoryAsync movieRepository, IGenreServiceAsync genreService)
        {
            this.movieRepository = movieRepository;
            this.genreService = genreService;
        }
        
        public async Task<MovieModel> GetMovieByIdAsync(int id)
        {
            Movie movie = await movieRepository.GetByIdAsync(id);
            var genres = await genreService.GetAllGenresAsync();
            if (movie != null && genres != null)
            {
                MovieModel model = new MovieModel()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Overview = movie.Overview,
                    ReleaseDate = movie.ReleaseDate,
                    Price = movie.Price,
                    Genres = genres.ToList(),
                    Tagline = movie.Tagline,
                    Revenue = movie.Revenue,
                    Budget = movie.Budget,
                    PosterUrl = movie.PosterUrl,
                };
                return model;
            }
            return null;
        }

        public async Task<IEnumerable<MovieModel>> GetAllMoviesAsync()
        {
            var movies = await movieRepository.GetAllAsync();
            if (movies != null)
            {
                List<MovieModel> models = new List<MovieModel>();
                foreach (var movie in movies)
                {
                    MovieModel model = new MovieModel()
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Overview = movie.Overview,
                        ReleaseDate = movie.ReleaseDate,
                        Genres = movie.MovieGenres,
                        Price = movie.Price,
                        Tagline = movie.Tagline,
                        Revenue = movie.Revenue,
                        Budget = movie.Budget,
                        PosterUrl = movie.PosterUrl,
                    };
                    models.Add(model);
                }
                return models;
            }
            return null;
        }

        public async Task<int> InsertMovieAsync(MovieModel movie)
        {
            Movie newMovie = new Movie()
            {
                Title = movie.Title,
                Overview = movie.Overview,
                ReleaseDate = movie.ReleaseDate,
                Price = movie.Price,
                Tagline = movie.Tagline,
                Revenue = movie.Revenue,
                Budget = movie.Budget,
                PosterUrl = movie.PosterUrl,
            };
            newMovie.MovieGenres = new List<Genre>();
            newMovie.MovieGenres.Add(await genreService.GetGenreById(movie.GenreId));
            return await movieRepository.InsertAsync(newMovie);
        }
    }
}
