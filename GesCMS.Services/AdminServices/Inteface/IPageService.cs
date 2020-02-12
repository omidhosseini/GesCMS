using GesCMS.Data.Entities;
using GesCMS.Services.BaseServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using GesCMS.ViewModels.AdminViewModel.Page;
using System.Threading;

namespace GesCMS.Services.AdminServices.Inteface
{
    public interface IPageService : IBaseService<Page, PageViewModel>
    {
        Task<List<PageViewModel>> PageList(Page page, CancellationToken cancellationToken);
    }
}
