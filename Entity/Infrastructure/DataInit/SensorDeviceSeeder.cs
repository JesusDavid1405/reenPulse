using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Infrastructure.DataInit.Implements
{
    public class SensorDeviceSeeder : IEntityTypeConfiguration<SensorDevice>
    {
        public void Configure(EntityTypeBuilder<SensorDevice> builder)
        {
            var seedDate = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new SensorDevice
                {
                    Id = 1,
                    DeviceId = "DEV-001",
                    Model = "SoilSense v1",
                    BatteryLevel = 95,
                    LastSeenAt = seedDate,
                    Status = "online",
                    CreatedAt = seedDate
                },
                new SensorDevice
                {
                    Id = 2,
                    DeviceId = "DEV-002",
                    Model = "SoilSense v1",
                    BatteryLevel = 85,
                    LastSeenAt = seedDate,
                    Status = "offline",
                    CreatedAt = seedDate
                }
            );
        }
    }
}
