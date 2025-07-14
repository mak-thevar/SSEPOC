using Microsoft.EntityFrameworkCore;
using SseDemo.Domain.Entities;

namespace SseDemo.Application.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Feed> Feeds { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}