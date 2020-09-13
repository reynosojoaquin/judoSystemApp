using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JudoApp.API.DAL
{
    public interface IGenericRepository<T> where T : class
{
    Task<T> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
    Task Add(T entity);
    Task Remove(T entity);
    Task Update (T entity);
    Task AddRange(IEnumerable<T> entities);
  
    Task RemoveRange(IEnumerable<T> entities);
    Task<int> CountWhere(Expression<Func<T, bool>> predicate);
}
}