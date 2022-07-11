using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarAuthServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CankutayUcarAuthServer.Data.Configuration
{
    public class UseAppConfiguration : IEntityTypeConfiguration<UserApp>
    {
        public void Configure(EntityTypeBuilder<UserApp> builder)
        {
            builder.Property(ua => ua.City)
                .HasMaxLength(50);
        }
    }
}
