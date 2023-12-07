using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Domain.Entity;

namespace YandexTaxi.Infrastructure.Persistance
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

            modelBuilder.Entity<Address>().Ignore(x => x.Orders);
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Taxi> Taxi { get; set; }
        public DbSet<User> User { get; set; }

    }
}
