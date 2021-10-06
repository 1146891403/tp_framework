namespace TP.Infrastructure.Common.Dependency
{
    public abstract class BootstrapperBase
    {
        private readonly static object syncObject = new object();
        
        public virtual void Run()
        {
            lock(syncObject)
            {
                ConfigureContainerBuilder();

                ConfigureApplication();

                ConfigureLogger();

                ConfigureOthers();

                ConfigureContainer();
            }
        }

        protected virtual void ConfigureContainerBuilder() { }

        protected virtual void ConfigureContainer() { }

        protected virtual void ConfigureLogger() { }

        protected virtual void ConfigureOthers() { }

        protected virtual void ConfigureApplication() { }
    }
}
