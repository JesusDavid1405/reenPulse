using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Infrastructure.Context
{
    public class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserPlant> UserPlants { get; set; }
        public DbSet<PlantSpecies> PlantSpecies { get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }
        public DbSet<SensorDevice> SensorDevices { get; set; }
        public DbSet<SensorReading> SensorReading { get; set; }
    }
}
