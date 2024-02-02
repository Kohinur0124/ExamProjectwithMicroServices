using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using YandexEats.Application.Abstractions;
using YandexEats.Model;
using StackExchange.Redis;
namespace YandexEats.Application.BackgraundServices
{
    public class BackgraundServices : BackgroundService
    {
        private readonly StackExchange.Redis.IDatabase _distributedCache;

        private readonly IServiceProvider _serviceProvider;

        public BackgraundServices(IServiceProvider serv)
        {

            _serviceProvider = serv;
            var redis = ConnectionMultiplexer.Connect("redis,6379");
             _distributedCache = redis.GetDatabase();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
           while (!stoppingToken.IsCancellationRequested)
           {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<IApplicationDbContext>();

                    var result = await dbContext.Users.ToListAsync();

                    if (result.Count > 0)
                    {

                        var newUser = new List<DtoLogin>();

                        foreach (var user in result)
                        {
                            newUser.Add(new DtoLogin
                            {
                                PhoneNumber = user.PhoneNumber,
                                Password = user.Password,
                                Role = user.Role,
                            });
                        }
                        await _distributedCache.StringSetAsync(
                             "GetAllUserYandexEats",
                             JsonConvert.SerializeObject(newUser)
                           );

                    }
                }
                await Task.Delay(TimeSpan.FromSeconds(10));
           }



        }
    }
}
