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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID)
                .UseIdentityColumn(1, 1);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(p => p.Stock)
                .IsRequired();
            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            builder.Property(p => p.UserId)
                .IsRequired();
        }
    }
}
