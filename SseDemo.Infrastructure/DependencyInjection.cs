using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SseDemo.Application.Interfaces;
using SseDemo.Infrastructure.Persistence;

namespace SseDemo.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("SseDemoDb"));

            services.AddScoped<IAppDbContext>(provider => provider.GetRequiredService<AppDbContext>());

            return services;
        }
    }
}