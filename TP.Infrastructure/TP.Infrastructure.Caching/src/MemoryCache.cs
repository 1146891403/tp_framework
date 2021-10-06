using System;
using TP.Infrastructure.Common.Caching;
using TP.Infrastructure.Common.Extensions;

namespace TP.Infrastructure.Caching
{
    public class MemoryCache : ICache
    {
        public bool Contains(string cacheKey)
        {
            return System.Runtime.Caching.MemoryCache.Default.Contains(cacheKey);
        }

        public TCache GetCache<TCache>(string cacheKey) where TCache : class
        {
            if (Contains(cacheKey))
                return System.Runtime.Caching.MemoryCache.Default.Get(cacheKey).As<TCache>();

            return default(TCache);
        }

        public void SetCache<TCache>(string cacheKey, TCache cache) where TCache : class
        {
            System.Runtime.Caching.MemoryCache.Default.Set(cacheKey, cache, DateTimeOffset.Now.AddMinutes(10));
        }

        public void SetCache<TCache>(string cacheKey, TCache cache, DateTimeOffset expireTime) where TCache : class
        {
            System.Runtime.Caching.MemoryCache.Default.Set(cacheKey, cache, expireTime);
        }

        public void RemoveCache()
        {
            foreach(var cache in System.Runtime.Caching.MemoryCache.Default)
            {
                this.RemoveCache(cache.Key);
            }
        }

        public void RemoveCache(string cacheKey)
        {
            System.Runtime.Caching.MemoryCache.Default.Remove(cacheKey);
        }
    }
}
