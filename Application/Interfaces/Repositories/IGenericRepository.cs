using System.Linq.Expressions;

using Domain.Common.Contracts;

namespace Application.Interfaces;

public interface IGenericRepository<T>  where T : BaseEntity
{
          Task<T> Create(T entity);
          Task<T> Update(T entity);
          Task<T> Get(Expression<Func<T, bool>> exp);
          Task<T> GetByCondition(Expression<Func<T, bool>> exp);
          Task<T> Get();
}
