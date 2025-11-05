using Entity.Infrastructure.DataInit;
using Entity.Infrastructure.DataInit.Implements;
using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new PlantCategorySeeder());
            //modelBuilder.ApplyConfiguration(new PlantSpeciesSeeder());
            //modelBuilder.ApplyConfiguration(new UserSeeder());
            //modelBuilder.ApplyConfiguration(new SensorDeviceSeeder());
            //modelBuilder.ApplyConfiguration(new UserPlantSeeder());
            //modelBuilder.ApplyConfiguration(new SensorReadingSeeder());
            //modelBuilder.ApplyConfiguration(new NotificationSeeder());
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
