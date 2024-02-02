using AuthApiExam.Model;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace AuthApiExam.Services
{
    public static  class FunctionforTests
    {

        private static dynamic redis = ConnectionMultiplexer.Connect("redis,6379");
        private static  readonly IDatabase _distributedCache = redis.GetDatabase();

       
        

        public  static bool isFoundUser(DtoLogin dtoLogin)
        {
            var cache = _distributedCache.StringGet("GetAllUserYandexEats");
            var lst = JsonConvert.DeserializeObject<List<DtoLogin>>(cache);

            var user = lst.FirstOrDefault(x => x.PhoneNumber == dtoLogin.PhoneNumber && x.Password == dtoLogin.Password && x.Role == dtoLogin.Role);
            if (user == null)
            {
                return false;
            }
            return true;

        }
    }
}
