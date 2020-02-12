using GesCMS.Data.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Repository.Repositories.BaseRepository
{
    class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        private readonly GesCMSDbContext _context;
        public Repository(GesCMSDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task BulkInsert(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await _entities.AddRangeAsync(entities, cancellationToken);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public async Task<IEnumerable<T>> GetList(CancellationToken cancellationToken)
        {
            return await _entities.ToListAsync(cancellationToken);
        }

        public IQueryable<T> GetQueryable()
        {
            return _entities;
        }

        public async Task Insert(T entity, CancellationToken cancellationToken)
        {
            await _entities.AddAsync(entity, cancellationToken);
        }

        public async Task Remove(T entity, CancellationToken cancellationToken)
        {
            if (entity == null)
                throw new Exception("entity null exception");
            var foundEntity = await _entities.FindAsync(entity, cancellationToken);
            //if (foundEntity != null)
            //{
            //    foundEntity.IsDeleted = true;
            //}
        }

        public async Task Update(T entity, CancellationToken cancellationToken)
        {
            if (entity == null)
                throw new Exception("entity null exception");
            var foundEntity = await _entities.FindAsync(entity, cancellationToken);
            if (foundEntity != null)
            {
                _entities.Update(entity);
            }
        }
    }
}
