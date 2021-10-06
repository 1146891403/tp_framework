using Autofac;
using TP.Infrastructure.Common.Dependency;

namespace TP.Infrastructure.Autofac
{
    public class AutofacBootstrapper : BootstrapperBase
    {
        private ContainerBuilder _currentBuilder;
        private IContainer _currentContainer;
        
        public virtual ContainerBuilder CurrentBuilder => _currentBuilder;

        public virtual IContainer CurrentContainer => _currentContainer;

        protected override void ConfigureContainerBuilder()
        {
            _currentBuilder = new ContainerBuilder();

            RegisterType<AutofacContainerFacade, IContainerFacade>();
        }

        protected override void ConfigureContainer()
        {
            _currentContainer = _currentBuilder.Build();

            var newBuilder = new ContainerBuilder();
            newBuilder.Register(r => new AutofacContainerProvider(_currentContainer)).As<IAutofacContainerProvider>();

#pragma warning disable CS0618 // Type or member is obsolete
            newBuilder.Update(_currentContainer);
#pragma warning restore CS0618 // Type or member is obsolete

            ServiceLocator.Initialize(() => CurrentContainer.Resolve<IContainerFacade>());
        }

        protected virtual void RegisterType<TImplementer, TInterface>() where TImplementer : TInterface
        {
            CurrentBuilder.RegisterType<TImplementer>().As<TInterface>();
        }
    }
}
