using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Infrastructure.DataInit.Implements
{
    public class UserSeeder : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var seedDate = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@smartagro.com",
                    Password = "admin123",
                    Role = "Administrator",
                    CreatedAt = seedDate
                },
                new User
                {
                    Id = 2,
                    Username = "demo",
                    Email = "demo@smartagro.com",
                    Password = "demo123",
                    Role = "User",
                    CreatedAt = seedDate
                }
            );
        }
    }
}
