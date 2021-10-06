using TP.Infrastructure.Common.Dependency;

namespace TP.Infrastructure.Common.Logging
{
    public interface ILoggerNet : ITransientDependency
    {
        void Debug(object message);

        void Error(object message);

        void Fatal(object message);

        void Info(object message);

        void Warn(object message);
    }
}
