using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Repository.Repositories.BaseRepository
{
    public interface IRepository<T> 
    {
        Task BulkInsert(IEnumerable<T> entities);
        Task Insert(T entity);
        Task Remove(T entity);
        Task Update(T entity);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryable();
        Task<IEnumerable<T>> GetList();
    }
}
