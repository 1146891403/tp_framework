using Autofac;

namespace TP.Infrastructure.Autofac
{
    public interface IAutofacContainerProvider
    {
        IContainer GetContainer();
    }
}
