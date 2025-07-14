using Microsoft.Extensions.DependencyInjection;

namespace SseDemo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Add application services here
            return services;
        }
    }
}