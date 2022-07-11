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
    public class UserRefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshToken>
    {
        public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
        {
            builder.HasKey(urk => urk.UserId);
            builder.Property(urk => urk.Code)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
