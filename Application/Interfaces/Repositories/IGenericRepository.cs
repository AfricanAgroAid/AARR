using System.Linq.Expressions;

using Domain.Common.Contracts;

namespace Application.Interfaces;

public interface IGenericRepository<T>  where T : BaseEntity
{
          Task<T> GetAsync(Expression<Func<T, bool>> exp);
          Task<IReadOnlyList<T>> GetAllAsync();
          Task<IReadOnlyList<T>> GetByConditionAsync(Expression<Func<T, bool>> exp);
          Task<T> UpdateAsync(T entity);
          Task<bool> DeleteAsync(T entity);
          Task<bool> SaveChanges();
}
