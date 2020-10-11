using cqrs.Domain.Entities;
using cqrs.Domain.Interfaces;
using cqrs.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cqrs.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly CqrsContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(CqrsContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public Task<TEntity> GetById(Guid id)
        {
            return _dbSet.FindAsync(id).AsTask();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }

        public Task Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
            return _dbContext.SaveChangesAsync();
        }

    }
}
