using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Infrastructure.DataInit
{
    public class PlantCategorySeeder : IEntityTypeConfiguration<PlantCategory>
    {
        public void Configure(EntityTypeBuilder<PlantCategory> builder)
        {
            var seedDate = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new PlantCategory { Id = 1, Name = "Suculentas", Description = "Plantas con hojas carnosas que almacenan agua.", CreatedAt = seedDate },
                new PlantCategory { Id = 2, Name = "Arbustos", Description = "Plantas leñosas de tamaño medio.", CreatedAt = seedDate },
                new PlantCategory { Id = 3, Name = "Árboles frutales", Description = "Árboles que producen frutos comestibles.", CreatedAt = seedDate },
                new PlantCategory { Id = 4, Name = "Flores ornamentales", Description = "Plantas cultivadas por la belleza de sus flores.", CreatedAt = seedDate }
            );
        }
    }
}
    