using GesCMS.Application.Common.Interfaces;
using GesCMS.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GesCMS.Core.Entities;
using Microsoft.Extensions.Options;
using AutoMapper.Configuration;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading;
using GesCMS.Core.Common;

namespace GesCMS.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration, DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<Page> Page { get; set; }
        public DbSet<Widget> Widget { get; set; }
        public DbSet<WidgetInPagePriority> WidgetInPagePriority { get; set; }
        public DbSet<WidgetsInPage> WidgetsInPage { get; set; }
        public DbSet<WidgetValue> WidgetValue { get; set; }
        public DbSet<WebTheme> WebTheme { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
