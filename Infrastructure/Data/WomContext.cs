using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infrastructure.Data
{
    public class WomContext : DbContext
    {
        public WomContext(DbContextOptions<WomContext> options) : base (options){}

        public DbSet<Consumer>  Consumers{get; set;}
        public DbSet<ConsumerProgram>  ConsumerPrograms{get; set;}
        public DbSet<ConsumerProgramPromotion>  ConsumerProgramPromotions{get; set;}
        public DbSet<Generation>  Generations{get; set;}
        public DbSet<Program>  Programs{get; set;}
        public DbSet<ProgramPromotion>  ProgramPromotions{get; set;}
        public DbSet<ProgramGenerationPeriod>  ProgramGenerationPeriods{get; set;}
        public DbSet<ProgramQuestion>  ProgramQuestions{get; set;}
        public DbSet<Source>  Sources{get; set;}
        public DbSet<Status>  Statuses{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            if(Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach(var entity in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entity.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));
                    foreach(var property in properties)
                    {
                        modelBuilder.Entity(entity.Name).Property(property.Name)
                            .HasConversion<double>();
                    }
                }

            }
        }
        
    }
}