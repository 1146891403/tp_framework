using Autofac;
using System;

namespace TP.Infrastructure.Autofac
{
    public class AutofacContainerProvider : IAutofacContainerProvider
    {
        public IContainer CurrentContainer { get; }

        public AutofacContainerProvider(IContainer container)
        {
            CurrentContainer = container ?? throw new ArgumentNullException(nameof(container));
        }

        public IContainer GetContainer()
        {
            return CurrentContainer;
        }
    }
}
