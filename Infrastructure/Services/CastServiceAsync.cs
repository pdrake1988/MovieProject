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
    public class CastServiceAsync : ICastServiceAsync
    {
        private readonly ICastRepositoryAsync castRepository;
        private readonly IMovieRepositoryAsync movieRepository;

        public CastServiceAsync(
            ICastRepositoryAsync castRepository,
            IMovieRepositoryAsync movieRepository
        )
        {
            this.castRepository = castRepository;
            this.movieRepository = movieRepository;
        }

        public async Task<int> CreateCastMember(CastModel cast)
        {
            Cast newCastMember = new Cast()
            {
                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                Movies = new List<Movie>()
            };
            newCastMember.Movies.Add(await movieRepository.GetByIdAsync(cast.MovieId));
            return await castRepository.InsertAsync(newCastMember);
        }

        public async Task<IEnumerable<CastModel>> GetAllCastMembersAsync()
        {
            var castMembers = await castRepository.GetAllAsync();
            if (castMembers != null)
            {
                List<CastModel> cast = new List<CastModel>();
                foreach (Cast model in castMembers)
                {
                    CastModel castModel = new CastModel()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Gender = model.Gender,
                        TmdbUrl = model.TmdbUrl,
                    };
                    cast.Add(castModel);
                }
                return cast;
            }
            return null;
        }

        public async Task<Cast> GetCastMemberByIdAsync(int id)
        {
            Cast cast = await castRepository.GetByIdAsync(id);
            if (cast != null)
            {
                return cast;
            }
            return null;
        }
    }
}
