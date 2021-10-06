using System;
using System.Collections.Generic;

namespace TP.Infrastructure.Common.Dependency
{
    /// <summary>
    /// The generic Container Facade interface. This interface is used
    /// to retrieve services (instances identified by type and optional
    /// name) from a container.
    /// </summary>
    public interface IContainerFacade
    {
        /// <summary>
        /// Get an instance of the given <paramref name="serviceType"/>.
        /// </summary>
        /// <param name="serviceType">Type of object requested.</param>
        /// <exception cref="ActivationException">if there is an error resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        object Resolve(Type serviceType);

        /// <summary>
        /// Get an instance of the given named <paramref name="serviceType"/>.
        /// </summary>
        /// <param name="serviceType">Type of object requested.</param>
        /// <param name="key">Name the object was registered with.</param>
        /// <exception cref="ActivationException">if there is an error resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        object Resolve(Type serviceType, string key);
        
        /// <summary>
        /// Get an instance of the given <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        TService Resolve<TService>();

        /// <summary>
        /// Get an instance of the given named <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">Type of object requested.</typeparam>
        /// <param name="key">Name the object was registered with.</param>
        /// <exception cref="ActivationException">if there is are errors resolving
        /// the service instance.</exception>
        /// <returns>The requested service instance.</returns>
        TService Resolve<TService>(string key);

        IEnumerable<TService> ResolveAll<TService>();
        
        bool TryResolve(Type serviceType, out object instance);
        
        bool TryResolve(string key, Type serviceType, out object instance);
        
        bool TryResolve<TService>(out TService instance);

        bool TryResolveAll<TService>(out IEnumerable<TService> instances);
    }
}
