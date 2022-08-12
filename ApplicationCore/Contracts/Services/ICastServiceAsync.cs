using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface ICastServiceAsync
    {
        Task<IEnumerable<CastModel>> GetAllCastMembersAsync();
        Task<Cast> GetCastMemberByIdAsync(int id);
        Task<int> CreateCastMember(CastModel cast);
    }
}
