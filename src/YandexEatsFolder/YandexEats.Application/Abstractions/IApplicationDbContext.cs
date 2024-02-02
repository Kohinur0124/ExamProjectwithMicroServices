using Microsoft.EntityFrameworkCore;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<Foods> Foods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
