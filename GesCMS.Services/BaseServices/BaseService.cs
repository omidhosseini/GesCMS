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
    public class BaseService<TModel, TDto> : IBaseService<TModel, TDto>
    {
        private readonly IRepository<TModel> _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public BaseService(IRepository<TModel> repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public virtual async Task<int> Add(TDto dto, CancellationToken cancellationToken)
        {
            await _repo.Insert(_mapper.Map<TModel>(dto), cancellationToken);
            return await _uow.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<int> AddItems(List<TDto> dtos, CancellationToken cancellationToken)
        {
            var objectList = _mapper.Map<List<TModel>>(dtos);
            await _repo.BulkInsert(objectList, cancellationToken);

            return await _uow.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<int> Remove(TDto dto, CancellationToken cancellationToken)
        {
            await _repo.Remove(_mapper.Map<TModel>(dto), cancellationToken);
            return await _uow.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<int> Update(TDto dto, CancellationToken cancellationToken)
        {
            await _repo.Update(_mapper.Map<TModel>(dto), cancellationToken);
            return await _uow.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<TDto> Find(long id, CancellationToken cancellationToken)
        {
            //var dto = _repo.FindBy(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);
            //return _mapper.Map<TDto>(dto);
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<TDto>> GetList(CancellationToken cancellationToken)
        {
            var dto = await _repo.GetList(cancellationToken);
            return _mapper.Map<List<TDto>>(dto);
        }

        public virtual async Task<IEnumerable<TDto>> GetListById(long id, CancellationToken cancellationToken)
        {
            //var dto = _repo.FindBy(x => x.Id == id).ToListAsync(cancellationToken);
            //return _mapper.Map<List<TDto>>(dto);
            throw new NotImplementedException();
        }

        public async Task<long> GetCountOfNoneDeleted(CancellationToken cancellationToken)
        {
            //return await (_repo.FindBy(x => x.IsDeleted == false)).CountAsync(cancellationToken);
            throw new NotImplementedException();
        }

        public async Task<long> GetCountOfAll(CancellationToken cancellationToken)
        {
            //return await (_repo.GetQueryable()).CountAsync(cancellationToken);
            throw new NotImplementedException();
        }
    }
}
