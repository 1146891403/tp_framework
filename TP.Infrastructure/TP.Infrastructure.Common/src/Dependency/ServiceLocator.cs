using System;

namespace TP.Infrastructure.Common.Dependency
{
    public static class ServiceLocator
    {
        private static IContainerFacade containerFacade;

        public static IContainerFacade Current => containerFacade;

        public static void Initialize(Func<IContainerFacade> containerFacadeAccessor)
        {
            containerFacade = containerFacadeAccessor.Invoke() ?? throw new ArgumentNullException(nameof(containerFacadeAccessor));
        }

        public static TService Resolve<TService>()
        {
            return Current.Resolve<TService>();
        }

        public static TService Resolve<TService>(string key)
        {
            return Current.Resolve<TService>(key);
        }

        public static object Resolve(Type serviceType)
        {
            return Current.Resolve(serviceType);
        }
        
        public static object Resolve(Type serviceType, string key)
        {
            return Current.Resolve(serviceType, key);
        }

        public static bool TryResolve<TService>(out TService service)
        {
            return Current.TryResolve<TService>(out service);
        }

        public static bool TryResolve(Type serviceType, out object service)
        {
            return Current.TryResolve(serviceType, out service);
        }
        
        public static bool TryResolve(Type serviceType, string key, out object service)
        {
            return Current.TryResolve(key, serviceType, out service);
        }
    }
}
