using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProgramQuestionConfiguration : IEntityTypeConfiguration<ProgramQuestion>
    {
        public void Configure(EntityTypeBuilder<ProgramQuestion> builder)
        {
           builder.Property(p => p.Id).HasColumnName("IdProgramQuestion");
           builder.Property(p => p.Question).HasMaxLength(250);
           builder.HasOne(p => p.Program).WithMany(a => a.ProgramQuestions)
                    .HasForeignKey(b => b.IdProgram);
        }
    }
}