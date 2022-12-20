using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReposotory<T> where T : class
    {
        Task<IReadOnlyList<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        void Add(T entity);
        void Update(T entity);
        void DeleteAsync(T entity);
        Task<int> SaveChangesAsync();
        IQueryable<T> GetQueryAble();
        Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> FindListAllAsync(Expression<Func<T, bool>> expression);
        List<int> GetUserAccessFileLocationList(decimal? userId);

    }
}
