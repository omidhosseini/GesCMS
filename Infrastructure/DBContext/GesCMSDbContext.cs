using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Infrastructure.DBContext
{
    public class GesCMSDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        private readonly IConfiguration _configuration;
        public GesCMSDbContext(IConfiguration configuration, DbContextOptions<GesCMSDbContext> options) : base(options)
        {
            _configuration = configuration;
        }

        #region DbSets
        public DbSet<Page> Page { get; set; }
        public DbSet<Widget> Widget { get; set; }
        public DbSet<WidgetInPagePriority> WidgetInPagePriority { get; set; }
        public DbSet<WidgetsInPage> WidgetsInPage { get; set; }
        public DbSet<WidgetValue> WidgetValue { get; set; }
        public DbSet<WebTheme> WebTheme { get; set; }
        #endregion
    }
}
