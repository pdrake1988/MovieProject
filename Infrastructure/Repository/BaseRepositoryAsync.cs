using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        public MovieDbContext movieDb;
        public BaseRepositoryAsync(MovieDbContext movieDb)
        {
            this.movieDb = movieDb;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await movieDb.Set<T>().FindAsync(id);
            movieDb.Set<T>().Remove(entity);
            return await movieDb.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await movieDb.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await movieDb.Set<T>().FindAsync(id);
        }

        public Task<int> InsertAsync(T entity)
        {
            movieDb.Set<T>().Add(entity);
            return movieDb.SaveChangesAsync();
        }

        public Task<int> UpdateAsync(T entity)
        {
            movieDb.Entry<T>(entity).State = EntityState.Modified;
            return movieDb.SaveChangesAsync();
        }
    }
}
