using Autofac;
using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Dependency;

namespace TP.Infrastructure.Autofac
{
    public class AutofacContainerFacade : IContainerFacade
    {
        private IAutofacContainerProvider _containerProvider;

        public AutofacContainerFacade(IAutofacContainerProvider containerProvider)
        {
            _containerProvider = containerProvider ?? throw new ArgumentNullException(nameof(containerProvider));
        }

        public IContainer CurrentContainer => _containerProvider.GetContainer();
        
        public object Resolve(Type serviceType) => CurrentContainer.Resolve(serviceType);

        public object Resolve(Type serviceType, string key) => CurrentContainer.ResolveKeyed(key, serviceType);

        public TService Resolve<TService>() => CurrentContainer.Resolve<TService>();

        public TService Resolve<TService>(string key) => CurrentContainer.ResolveKeyed<TService>(key);

        public IEnumerable<TService> ResolveAll<TService>() => CurrentContainer.Resolve<IEnumerable<TService>>();

        public bool TryResolve(Type serviceType, out object instance) => CurrentContainer.TryResolve(serviceType, out instance);

        public bool TryResolve(string key, Type serviceType, out object instance) => CurrentContainer.TryResolveKeyed(key, serviceType, out instance);

        public bool TryResolve<TService>(out TService instance) => CurrentContainer.TryResolve(out instance);

        public bool TryResolveAll<TService>(out IEnumerable<TService> instance) => CurrentContainer.TryResolve<IEnumerable<TService>>(out instance);
    }
}
