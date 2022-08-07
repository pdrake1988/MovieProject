using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
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
            Genre newGenre = new Genre()
            {
                Id = genre.Id,
                Name = genre.Name
            };
            return await genreRepository.InsertAsync(newGenre);
        }

        public Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            return genreRepository.GetAllAsync();
        }

        public Task<Genre> GetGenreById(int id)
        {
            return genreRepository.GetByIdAsync(id);
        }
    }
}
