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
                var genres = await genreService.GetAllGenresAsync();
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

        public Task<int> InsertMovieAsync(MovieModel movieModel)
        {
            Movie movie = new Movie()
            {
                Title = movieModel.Title,
                Overview = movieModel.Overview,
                ReleaseDate = movieModel.ReleaseDate,
                Price = movieModel.Price,
                Tagline = movieModel.Tagline,
                Revenue = movieModel.Revenue,
                Budget = movieModel.Budget,
                PosterUrl = movieModel.PosterUrl,
                MovieGenres = movieModel.Genres.ToList(),
            };
            return movieRepository.InsertAsync(movie);
        }
    }
}
