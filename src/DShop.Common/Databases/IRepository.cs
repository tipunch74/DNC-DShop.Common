using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DShop.Messages.Entities;

namespace DShop.Common.Databases
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
         Task<TEntity> GetByIdAsync(Guid id);
         Task CreateAsync(TEntity entity);
         Task UpdateAsync(TEntity entity);
         Task DeleteAsync(Guid id); 
         Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate);
    }
}