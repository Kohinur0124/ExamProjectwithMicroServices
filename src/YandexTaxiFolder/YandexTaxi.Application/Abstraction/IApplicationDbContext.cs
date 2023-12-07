using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexTaxi.Domain.Entity;

namespace YandexTaxi.Application.Abstraction
{
    public interface IApplicationDbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Taxi> Taxi { get; set; }
        public DbSet<User> User { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
