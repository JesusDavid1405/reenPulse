using Entity.Models.Base;
using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entity.Infrastructure.Context
{
    public class MySqlApplicationDbContext : DbContext
    {
        public MySqlApplicationDbContext(DbContextOptions<MySqlApplicationDbContext> options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime(6)");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Charset/Collation recomendados para MySQL 8
            modelBuilder
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            // ========= Ajuste clave para BaseModel.CreatedAt (DateTime) =========
            // Guardamos en UTC como datetime(6) y default en BD con CURRENT_TIMESTAMP(6)
            var dtoToUtc = new ValueConverter<DateTime, DateTime>(
                v => v.ToUniversalTime(),
                v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            foreach (var et in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseModel).IsAssignableFrom(et.ClrType))
                {
                    var b = modelBuilder.Entity(et.ClrType);

                    b.Property(nameof(BaseModel.CreatedAt))
                     .HasConversion(dtoToUtc)
                     .HasColumnType("datetime(6)")
                     .IsRequired()
                     .ValueGeneratedOnAdd()
                     .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
                }
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserPlant> UserPlants { get; set; }
        public DbSet<PlantSpecies> PlantSpecies { get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }
        public DbSet<SensorDevice> SensorDevices { get; set; }
        public DbSet<SensorReading> sensorReading { get; set; }
    }
}
