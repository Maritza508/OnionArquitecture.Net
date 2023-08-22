using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> filtro = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filtro);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
