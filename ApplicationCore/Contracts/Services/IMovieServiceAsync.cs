using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieServiceAsync
    {
        Task<MovieModel> GetMovieByIdAsync(int id);
        Task<IEnumerable<MovieModel>> GetAllMoviesAsync();
        Task<int> InsertMovieAsync(MovieModel movie);
    }
}
