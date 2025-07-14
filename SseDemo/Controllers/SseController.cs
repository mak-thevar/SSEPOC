using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SseDemo.Application.Interfaces;
using SseDemo.Domain.Entities;
using System.Text.Json;
using System.Threading.Tasks;

namespace SseDemo.Controllers
{
    public class SseController : Controller
    {
        private readonly IAppDbContext _context;

        public SseController(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var feeds = await _context.Feeds.OrderByDescending(f => f.Timestamp).ToListAsync();
            return View(feeds);
        }

        [HttpGet]
        public async Task Stream()
        {
            Response.Headers.Append("Content-Type", "text/event-stream");
            Response.Headers.Append("Cache-Control", "no-cache");
            Response.Headers.Append("Connection", "keep-alive");

            var random = new Random();

            var feedCount = await _context.Feeds.CountAsync();

            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(random.Next(2000, 7000)); // Simulate delay

                var newFeed = new Feed
                {
                    Title = $"New Feed Post #{feedCount + i + 1}",
                    Content = $"This is a dynamically generated feed post at {DateTime.UtcNow:T}.",
                    Timestamp = DateTime.UtcNow
                };

                _context.Feeds.Add(newFeed);
                await _context.SaveChangesAsync();

                var json = JsonSerializer.Serialize(newFeed, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                await Response.WriteAsync($"data: {json}\n\n");
                await Response.Body.FlushAsync();
            }
        }
    }
}