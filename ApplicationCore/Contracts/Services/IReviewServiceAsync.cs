using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IReviewServiceAsync
    {
        Task<IEnumerable<ReviewModel>> GetAllAsync();
        Task<int> CreateAsync(ReviewModel review);
    }
}
