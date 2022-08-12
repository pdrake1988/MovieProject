using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenreServiceAsync :  IGenreServiceAsync
    {
        IGenreRepositoryAsync genreRepository;
        public GenreServiceAsync(IGenreRepositoryAsync genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public async Task<int> CreateGenre(Genre genre)
        { 
            return await genreRepository.InsertAsync(genre);
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            return await genreRepository.GetAllAsync();
        }

        public async Task<Genre> GetGenreById(int id)
        {
            return await genreRepository.GetByIdAsync(id);
        }
    }
}
