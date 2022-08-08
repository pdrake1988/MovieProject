using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IGenreServiceAsync
    {
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        Task<int> CreateGenre(Genre genre);
    }
}
