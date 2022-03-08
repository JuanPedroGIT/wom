using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProgramGenerationPeriodConfiguration : IEntityTypeConfiguration<ProgramGenerationPeriod>
    {
        public void Configure(EntityTypeBuilder<ProgramGenerationPeriod> builder)
        {
           builder.Property(p=>p.Id).HasColumnName("IdProgramGenerationPeriod");
           builder.Property(p => p.TrafficSource).HasMaxLength(255);
           builder.HasOne(p =>p.Generation).WithMany().HasForeignKey(q=> q.IdGeneration);
           builder.HasOne(p =>p.Program).WithMany().HasForeignKey(q=> q.IdProgram);

        }
    }
}