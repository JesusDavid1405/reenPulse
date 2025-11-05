using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Infrastructure.DataInit.Implements
{
    public class SensorReadingSeeder : IEntityTypeConfiguration<SensorReading>
    {
        public void Configure(EntityTypeBuilder<SensorReading> builder)
        {
            var timestamp = new DateTime(2025, 01, 01, 8, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new SensorReading
                {
                    Id = 1,
                    SensorDeviceId = 1,
                    UserPlantId = 1,
                    SoilMoisture = 45,
                    PH = 6.5f,
                    SoilTemperature = 24,
                    CreatedAt = timestamp
                },
                new SensorReading
                {
                    Id = 2,
                    SensorDeviceId = 2,
                    UserPlantId = 2,
                    SoilMoisture = 35,
                    PH = 6.8f,
                    SoilTemperature = 26,
                    CreatedAt = timestamp.AddMinutes(10)
                }
            );
        }
    }
}
