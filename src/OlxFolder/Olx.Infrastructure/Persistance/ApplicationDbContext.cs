using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Olx.Application.Abstraction;
using Olx.Domain.Entity;

namespace Olx.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            if (databaseCreator != null)
            {
                if (!databaseCreator.CanConnect()) databaseCreator.Create();
                if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x=>x.Order).WithOne(x=>x.User).OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Card> Cards { get ; set ; }
        public DbSet<Catalog> Catalog { get ; set ; }
        public DbSet<Product> Products { get ; set ; }
        public DbSet<Order> Order { get ; set ; }
        public DbSet<User> User { get ; set ; }
    }
}
