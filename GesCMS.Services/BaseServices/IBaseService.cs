using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Services.BaseServices
{
    public interface IBaseService<TDB, TVM> 
    {
        Task<int> Add(TVM dto);
        Task<int> AddItems(List<TVM> dtos);
        Task<int> Remove(TVM dto);
        Task<int> Update(TVM dto);

        Task<TVM> Find(long id);
        Task<IEnumerable<TVM>> GetList();
        Task<IEnumerable<TVM>> GetListById();

        Task<long> GetCountOfNoneDeleted();
        Task<long> GetCountOfAll();
    }
}
