using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RacingGameDAL.Models;
using System;

namespace RacingGameDAL
{
    public class RacingDBContext : DbContext
    {
        public RacingDBContext(DbContextOptions<RacingDBContext> options) : base(options)
        { 
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source =.\IPSQLSERVER; Initial Catalog = RacingGame; Integrated Security = True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ComponentTypeMap(modelBuilder.Entity<ComponentType>());
            new ManufacturerMap(modelBuilder.Entity<Manufacturer>());
            new EngineMap(modelBuilder.Entity<Engine>());
        }
        public class ComponentTypeMap
        {
            public ComponentTypeMap(EntityTypeBuilder<ComponentType> entityBuilder)
            {
                entityBuilder.ToTable("ComponentTypes");
                //can apply IsUnique only to indexed properties
                entityBuilder.HasIndex(x => x.Name).IsUnique();
            }
        }
        public class ManufacturerMap
        {
            public ManufacturerMap(EntityTypeBuilder<Manufacturer> entityBuilder)
            {
                entityBuilder.ToTable("Manufactures");
                entityBuilder.HasIndex(x => x.Name).IsUnique();
            }
        }
        public class EngineMap
        {
            public EngineMap(EntityTypeBuilder<Engine> entityBuilder)
            {
                entityBuilder.ToTable("Engines");
                entityBuilder.HasIndex(x => x.Name).IsUnique();
            }
        }
    }
}
