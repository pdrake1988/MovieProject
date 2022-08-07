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
    public class PurchaseRepositoryAsync : BaseRepositoryAsync<Purchase>, IPurchaseRepositoryAsync
    {
        public PurchaseRepositoryAsync(MovieDbContext movieDb) : base(movieDb)
        {
        }
    }
}
