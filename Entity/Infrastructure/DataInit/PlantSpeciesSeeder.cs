using Entity.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Infrastructure.DataInit.Implements
{
    public class PlantSpeciesSeeder : IEntityTypeConfiguration<PlantSpecies>
    {
        public void Configure(EntityTypeBuilder<PlantSpecies> builder)
        {
            var seedDate = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new PlantSpecies
                {
                    Id = 1,
                    PlantCategoryId = 1,
                    ScientificName = "Aloe barbadensis miller",
                    CommonName = "Aloe Vera",
                    OptSoliMoistureMin = 30,
                    OptSoliMoistureMax = 50,
                    OptPHMin = 6.0f,
                    OptPHMax = 7.5f,
                    OptSolilTempMin = 18,
                    OptSolilTempMax = 27,
                    CreatedAt = seedDate
                },
                new PlantSpecies
                {
                    Id = 2,
                    PlantCategoryId = 2,
                    ScientificName = "Salvia rosmarinus",
                    CommonName = "Romero",
                    OptSoliMoistureMin = 40,
                    OptSoliMoistureMax = 60,
                    OptPHMin = 6.0f,
                    OptPHMax = 7.5f,
                    OptSolilTempMin = 15,
                    OptSolilTempMax = 30,
                    CreatedAt = seedDate
                },
                new PlantSpecies
                {
                    Id = 3,
                    PlantCategoryId = 3,
                    ScientificName = "Mangifera indica",
                    CommonName = "Mango",
                    OptSoliMoistureMin = 50,
                    OptSoliMoistureMax = 70,
                    OptPHMin = 5.5f,
                    OptPHMax = 7.5f,
                    OptSolilTempMin = 20,
                    OptSolilTempMax = 35,
                    CreatedAt = seedDate
                },
                new PlantSpecies
                {
                    Id = 4,
                    PlantCategoryId = 4,
                    ScientificName = "Rosa gallica",
                    CommonName = "Rosa",
                    OptSoliMoistureMin = 40,
                    OptSoliMoistureMax = 70,
                    OptPHMin = 6.0f,
                    OptPHMax = 6.8f,
                    OptSolilTempMin = 15,
                    OptSolilTempMax = 28,
                    CreatedAt = seedDate
                }
            );
        }
    }
}
