using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ConsumerProgramAnswerConfiguration : IEntityTypeConfiguration<ConsumerProgramAnswer>
    {
        public void Configure(EntityTypeBuilder<ConsumerProgramAnswer> builder)
        {
            builder.Property(p => p.Id).HasColumnName("IdConsumerProgramAnswer");
            builder.Property(p => p.Answer).HasMaxLength(255);
            builder.HasOne(p =>p.ConsumerProgram).WithMany()
                    .HasForeignKey(q => q.IdConsumerProgram);
            builder.HasOne(p => p.ProgramQuestion).WithMany()
                    .HasForeignKey(q =>q.IdProgramQuestion);

        }
    }
}