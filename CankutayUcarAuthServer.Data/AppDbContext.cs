using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarAuthServer.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CankutayUcarAuthServer.Data
{
    public class AppDbContext : IdentityDbContext<UserApp,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions):base(contextOptions)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);
        }
    }
}
