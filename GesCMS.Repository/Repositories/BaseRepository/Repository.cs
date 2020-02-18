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
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        private readonly GesCMSDbContext _context;
        public Repository(GesCMSDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task BulkInsert(IEnumerable<T> entities)
        {
            await _entities.AddRangeAsync(entities);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public async Task<IEnumerable<T>> GetList()
        {
            return await _entities.ToListAsync();
        }

        public IQueryable<T> GetQueryable()
        {
            return _entities;
        }

        public async Task Insert(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Remove(T entity)
        {
            if (entity == null)
                throw new Exception("entity null exception");
            var foundEntity = await _entities.FindAsync(entity);
            //if (foundEntity != null)
            //{
            //    foundEntity.IsDeleted = true;
            //}
        }

        public async Task Update(T entity)
        {
            if (entity == null)
                throw new Exception("entity null exception");
            var foundEntity = await _entities.FindAsync(entity);
            if (foundEntity != null)
            {
                _entities.Update(entity);
            }
        }
    }
}
