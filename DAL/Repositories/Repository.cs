using DAL.Data;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(TEntity entity)
        {
            _dataContext.Set<TEntity>().Add(entity);
        }

        public void DetachEntity(TEntity entity)
        {
            _dataContext.Entry<TEntity>(entity).State = EntityState.Detached;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dataContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetById(int id)
        {
            var result = await _dataContext.Set<TEntity>().FindAsync(id);
            return result;
        }

        public void Remove(TEntity entity)
        {
            _dataContext.Set<TEntity>().Remove(entity);
        }

        public Task SaveChangesAsync()
        {
            return _dataContext.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _dataContext.Set<TEntity>().Update(entity);
            _dataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
