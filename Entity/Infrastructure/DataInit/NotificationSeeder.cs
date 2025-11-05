using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Infrastructure.DataInit.Implements
{
    public class NotificationSeeder : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            var seedDate = new DateTime(2025, 01, 01, 9, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new Notification
                {
                    Id = 1,
                    UserPlantId = 1,
                    Level = "info",
                    Title = "Sensor conectado",
                    Message = "El sensor DEV-001 se ha conectado correctamente.",
                    CreatedAt = seedDate
                },
                new Notification
                {
                    Id = 2,
                    UserPlantId = 2,
                    Level = "warning",
                    Title = "Baja humedad detectada",
                    Message = "La humedad del suelo cayó por debajo del 30%.",
                    CreatedAt = seedDate
                }
            );
        }
    }
}
