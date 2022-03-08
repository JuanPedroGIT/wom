using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ConsumerProgramPromotionConfiguration : IEntityTypeConfiguration<ConsumerProgramPromotion>
    {
        public void Configure(EntityTypeBuilder<ConsumerProgramPromotion> builder)
        {
            builder.Property(p => p.Id).HasColumnName("IdConsumerProgramPromotion");
            builder.Property(P => P.Answer).HasMaxLength(255);
            builder.HasOne(a => a.ConsumerProgram)
                    .WithMany().HasForeignKey(b => b.IdConsumerProgram);
            builder.HasOne(a => a.ProgramPromotion)
                    .WithMany().HasForeignKey(b => b.IdProgramPromotion);       
            builder.HasOne(a => a.Status)
                    .WithMany().HasForeignKey(b =>b.IdStatus);

        
        }
    }
}