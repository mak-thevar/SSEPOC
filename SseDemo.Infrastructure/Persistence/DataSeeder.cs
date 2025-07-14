using SseDemo.Domain.Entities;
using System.Linq;

namespace SseDemo.Infrastructure.Persistence
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Feeds.Any())
            {
                context.Feeds.AddRange(
                    new Feed { Id = 1, Title = "Welcome to the Live Feed!", Content = "This is the first post.", Timestamp = DateTime.UtcNow },
                    new Feed { Id = 2, Title = "Second Post", Content = "This is another post to get things started.", Timestamp = DateTime.UtcNow.AddMinutes(-5) }
                );
                context.SaveChanges();
            }
        }
    }
}