using AutoMapper;
using GesCMS.Data.Entities;
using GesCMS.Repository.Repositories;
using GesCMS.Repository.Repositories.BaseRepository;
using GesCMS.Repository.UnitOfWork;
using GesCMS.Services.AdminServices.Inteface;
using GesCMS.Services.BaseServices;
using GesCMS.ViewModels.AdminViewModel.Page;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GesCMS.Services.AdminServices.Services
{
    public class PageService : BaseService<Page, PageViewModel>, IPageService
    {
        private readonly IPageRepository _pageRepository;
        private readonly IRepository<Page> _repo;
        private readonly IMapper _mapper;

        public PageService(IRepository<Page> repo, IMapper mapper, IUnitOfWork uow) : base(repo, mapper, uow)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<PageViewModel>> PageList(Page page)
        {
            var result = await _repo.GetQueryable().ToListAsync();
            var res = _mapper.Map<List<PageViewModel>>(result);
            return res;
        }
    }
}
