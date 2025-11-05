using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Infrastructure.DataInit.Implements
{
    public class UserPlantSeeder : IEntityTypeConfiguration<UserPlant>
    {
        public void Configure(EntityTypeBuilder<UserPlant> builder)
        {
            var seedDate = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new UserPlant
                {
                    Id = 1,
                    Nickname = "Mi Aloe",
                    UserId = 2,
                    PlantSpeciesId = 1,
                    SensorDeviceId = 1,
                    CreatedAt = seedDate
                },
                new UserPlant
                {
                    Id = 2,
                    Nickname = "Mango Dulce",
                    UserId = 2,
                    PlantSpeciesId = 3,
                    SensorDeviceId = 2,
                    CreatedAt = seedDate
                }
            );
        }
    }
}
