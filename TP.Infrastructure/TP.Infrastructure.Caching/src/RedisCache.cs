using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Caching;

namespace TP.Infrastructure.Caching
{
    public class RedisCache : ICache
    {
        public bool Contains(string cacheKey)
        {
            throw new NotImplementedException();
        }

        public TCache GetCache<TCache>(string cacheKey) where TCache : class
        {
            throw new NotImplementedException();
        }

        public void RemoveCache()
        {
            throw new NotImplementedException();
        }

        public void RemoveCache(string cacheKey)
        {
            throw new NotImplementedException();
        }

        public void SetCache<TCache>(string cacheKey, TCache cache) where TCache : class
        {
            throw new NotImplementedException();
        }

        public void SetCache<TCache>(string cacheKey, TCache cache, DateTimeOffset expireTime) where TCache : class
        {
            throw new NotImplementedException();
        }
    }
}
