using GesCMS.Data.DbContext;
using System;
using System.Threading.Tasks;

namespace GesCMS.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private GesCMSDbContext _context;

        public UnitOfWork(GesCMSDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }

    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();
    }
}
