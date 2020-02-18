using GesCMS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GesCMS.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Core.Entities.Page> Page { get; set; }
        public DbSet<Widget> Widget { get; set; }
        public DbSet<WidgetInPagePriority> WidgetInPagePriority { get; set; }
        public DbSet<WidgetsInPage> WidgetsInPage { get; set; }
        public DbSet<WidgetValue> WidgetValue { get; set; }
        public DbSet<WebTheme> WebTheme { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
