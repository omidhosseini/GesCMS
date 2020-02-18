using AutoMapper;
using GesCMS.Repository.Repositories.BaseRepository;
using GesCMS.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Services.BaseServices
{
    public class BaseService<TDb, TviewModel> : IBaseService<TDb, TviewModel> 
    {
        private readonly IRepository<TDb> _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public BaseService(IRepository<TDb> repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public virtual async Task<int> Add(TviewModel dto)
        {
            await _repo.Insert(_mapper.Map<TDb>(dto));
            return await _uow.SaveChangesAsync();
        }

        public virtual async Task<int> AddItems(List<TviewModel> dtos)
        {
            var objectList = _mapper.Map<List<TDb>>(dtos);
            await _repo.BulkInsert(objectList);

            return await _uow.SaveChangesAsync();
        }

        public virtual async Task<int> Remove(TviewModel dto)
        {
            await _repo.Remove(_mapper.Map<TDb>(dto));
            return await _uow.SaveChangesAsync();
        }

        public virtual async Task<int> Update(TviewModel dto)
        {
            await _repo.Update(_mapper.Map<TDb>(dto));
            return await _uow.SaveChangesAsync();
        }

        public virtual async Task<TviewModel> Find(long id)
        {
            //var dto = _repo.FindBy(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);
            //return _mapper.Map<TDto>(dto);
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<TviewModel>> GetList()
        {
            var dto = await _repo.GetList();
            return _mapper.Map<List<TviewModel>>(dto);
        }

        public virtual async Task<IEnumerable<TviewModel>> GetListById(long id)
        {
            //var dto = _repo.FindBy(x => x.Id == id).ToListAsync(cancellationToken);
            //return _mapper.Map<List<TDto>>(dto);
            throw new NotImplementedException();
        }

        public async Task<long> GetCountOfNoneDeleted()
        {
            //return await (_repo.FindBy(x => x.IsDeleted == false)).CountAsync(cancellationToken);
            throw new NotImplementedException();
        }

        public async Task<long> GetCountOfAll()
        {
            //return await (_repo.GetQueryable()).CountAsync(cancellationToken);
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TviewModel>> GetListById()
        {
            throw new NotImplementedException();
        }
    }
}
