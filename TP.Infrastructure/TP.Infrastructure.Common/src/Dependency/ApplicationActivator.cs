using System;

namespace TP.Infrastructure.Common.Dependency
{
    public class ApplicationActivator
    {
        public static void Run<TBootstrapper>(Func<TBootstrapper> bootstrapperFactory) where TBootstrapper : BootstrapperBase
        {
            try
            {
                var bootstrapper = bootstrapperFactory.Invoke();

                bootstrapper.Run();
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message);
            }
        }
    }
}
