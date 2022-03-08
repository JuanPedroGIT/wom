using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class SourceConfiguration : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.Property(p => p.Id).HasColumnName("IdSource");
            builder.Property(p => p.SourceName).HasMaxLength(50);
            builder.Property(p => p.SourceCripto).HasMaxLength(255);

        }
    }
}