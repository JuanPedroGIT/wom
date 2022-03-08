using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.Property(p=>p.Id).HasColumnName("IdProgram");
            builder.Property(p=>p.ProgramName).HasMaxLength(50);
        }
    }
}