using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MovieRepositoryAsync : BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        public MovieRepositoryAsync(MovieDbContext movieDb) : base(movieDb)
        {
        }
    }
}
