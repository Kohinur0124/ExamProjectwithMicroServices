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
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
