using Application.Services;
using Domain.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Anime>, AnimeService>();
            return services;
        }
    }
}
