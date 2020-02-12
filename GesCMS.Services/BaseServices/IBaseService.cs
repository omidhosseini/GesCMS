using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Services.BaseServices
{
    public interface IBaseService<TDB, TVM>                
    {
        Task<int> Add(TVM dto, CancellationToken cancellationToken);
        Task<int> AddItems(List<TVM> dtos, CancellationToken cancellationToken);
        Task<int> Remove(TVM dto, CancellationToken cancellationToken);
        Task<int> Update(TVM dto, CancellationToken cancellationToken);

        Task<TVM> Find(long id, CancellationToken cancellationToken);
        Task<IEnumerable<TVM>> GetList(CancellationToken cancellationToken);
        Task<IEnumerable<TVM>> GetListById(long id, CancellationToken cancellationToken);

        Task<long> GetCountOfNoneDeleted(CancellationToken cancellationToken);
        Task<long> GetCountOfAll(CancellationToken cancellationToken);
    }
}
