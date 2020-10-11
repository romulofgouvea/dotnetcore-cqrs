using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cqrs.Domain.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Add(TEntity obj);
        Task Update(TEntity obj);
        Task Remove(TEntity obj);
    }
}