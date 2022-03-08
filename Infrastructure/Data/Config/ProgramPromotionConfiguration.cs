using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProgramPromotionConfiguration : IEntityTypeConfiguration<ProgramPromotion>
    {
        public void Configure(EntityTypeBuilder<ProgramPromotion> builder)
        {
            builder.Property(p => p.Id).HasColumnName("IdProgramPromotion");
            builder.Property(p => p.Name).HasMaxLength(255);
            builder.HasOne(p => p.Program).WithMany()
                    .HasForeignKey(b => b.IdProgram);
        }
    }
}