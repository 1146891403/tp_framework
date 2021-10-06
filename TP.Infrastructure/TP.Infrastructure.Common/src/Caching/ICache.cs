using System;
using TP.Infrastructure.Common.Dependency;

namespace TP.Infrastructure.Common.Caching
{
    public interface ICache : ITransientDependency
    {
        bool Contains(string cacheKey);

        TCache GetCache<TCache>(string cacheKey) where TCache : class;

        void SetCache<TCache>(string cacheKey, TCache cache) where TCache : class;

        void SetCache<TCache>(string cacheKey, TCache cache, DateTimeOffset expireTime) where TCache : class;

        void RemoveCache();

        void RemoveCache(string cacheKey);
    }
}
