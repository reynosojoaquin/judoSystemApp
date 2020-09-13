using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JudoApp.API.DAL;
using Microsoft.EntityFrameworkCore;

namespace JudoApp.API.Repositorios
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly judoAppDataContext _context;
    public  GenericRepository(judoAppDataContext context)
    {
            _context = context;
    }
    public async Task Add(T entity)
    {
         _context.Set<T>().Add(entity);
    }
    public async Task AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public async Task<int> CountWhere(Expression<Func<T, bool>> predicate){
              return await _context.Set<T>().CountAsync(predicate);
    }

    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }
    public async Task<IEnumerable<T>> GetAll()
    {
        return _context.Set<T>().ToList();
    }
    public async Task<T> GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
    public async Task Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public async Task RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }
     public async Task Update(T entity)
    {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChangesAsync();
    }
    
}
}