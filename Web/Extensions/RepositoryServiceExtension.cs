using Data.Interfaces.IDataBasic;
using Data.Repository;

namespace Web.Extensions
{
    public static class RepositoryServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IDataBasic<>), typeof(DataGeneric<>));
            return services;
        }
    }
}
