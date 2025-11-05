using Entity.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Web.Extensions
{
    public static class DatabaseServiceExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }
    }
}
