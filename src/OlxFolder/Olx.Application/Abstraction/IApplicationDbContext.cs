using Microsoft.EntityFrameworkCore;
using Olx.Domain.Entity;



namespace Olx.Application.Abstraction
{
    public interface IApplicationDbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<User> User { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
