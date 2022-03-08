using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class GenerationConfiguration : IEntityTypeConfiguration<Generation>
    {
        public void Configure(EntityTypeBuilder<Generation> builder)
        {
            builder.Property(P=>P.Id).HasColumnName("IdGeneration");
            builder.Property(p => p.GenerationName).HasMaxLength(50);
        }
    }
}