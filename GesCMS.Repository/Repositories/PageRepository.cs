using GesCMS.Data.DbContext;
using GesCMS.Data.Entities;
using GesCMS.Repository.Repositories.BaseRepository;

namespace GesCMS.Repository.Repositories
{
    public class PageRepository : Repository<Page>, IPageRepository
    {
        public PageRepository(GesCMSDbContext context) : base(context)
        {
        }
    }
}
