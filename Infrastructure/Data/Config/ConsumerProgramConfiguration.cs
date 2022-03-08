using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Infrastructure.Data.Config
{
    public class ConsumerProgramConfiguration : IEntityTypeConfiguration<ConsumerProgram>
    {
        public void Configure(EntityTypeBuilder<ConsumerProgram> builder)
        {
            builder.Property(p => p.Id).HasColumnName("IdConsumerProgram");
            builder.Property(p=>p.ActivationCode).HasMaxLength(50);
            builder.HasOne(p => p.Consumer).WithMany().HasForeignKey(q =>q.IdConsumer);
            builder.HasOne(p => p.Program).WithMany().HasForeignKey(q =>q.IdProgram);
            builder.HasOne(p => p.Source).WithMany().HasForeignKey(q =>q.IdSource);
            builder.HasOne(p => p.Status).WithMany().HasForeignKey(q =>q.IdStatus);
            builder.HasOne(p => p.Generation).WithMany().HasForeignKey(q =>q.IdGeneration);
        }
    }
}