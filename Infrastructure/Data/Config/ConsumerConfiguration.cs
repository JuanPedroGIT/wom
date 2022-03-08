using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ConsumerConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder.Property(p => p.Id).IsRequired().HasColumnName("IdConsumer");
            builder.Property(p =>p.Name ).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(100);
        }
    }
}