using log4net;
using System;
using TP.Infrastructure.Common.Logging;

namespace TP.Infrastructure.Logging
{
    public class LoggerNet : ILoggerNet
    {
        private readonly ILog _log;

        public LoggerNet(ILog log)
        {
            _log = log ?? throw new ArgumentNullException(nameof(log));
        }

        public void Debug(object message)
        {
            if (_log.IsDebugEnabled)
                _log.Debug(message);
        }

        public void Error(object message)
        {
            if (_log.IsErrorEnabled)
                _log.Error(message);
        }

        public void Fatal(object message)
        {
            if (_log.IsFatalEnabled)
                _log.Fatal(message);
        }

        public void Info(object message)
        {
            if (_log.IsInfoEnabled)
                _log.Info(message);
        }

        public void Warn(object message)
        {
            if (_log.IsWarnEnabled)
                _log.Warn(message);
        }
    }
}
