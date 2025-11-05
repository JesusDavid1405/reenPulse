using AutoMapper;
using Business.Mapping;

namespace Web.Extensions
{
    public static class AutoMapperServiceExtension
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Map)); // clase de tu perfil AutoMapper
            return services;
        }
    }
}
