using System;
using Common.Logging;
using MFramework.Common.Core.Logging.Contexts;

namespace MFramework.Common.Core.Logging
{
    public class Log:ILog
    {
        private global::Common.Logging.ILog _log;

        private  Log(object o):this(o.GetType())
        {
            
        }
        private Log(Type t)
            : this(LogTypeDescriptor(t))
        {
            
        }
        private Log(string name)
        {
            _log = LogManager.GetLogger(name);
        }
        public void Trace(object message)
        {
            _log.Trace(message);
        }

        public void Trace(object message, Exception exception)
        {
            _log.Trace(message, exception);
        }

        public void TraceFormat(string format, params object[] args)
        {
            _log.TraceFormat(format, args);
        }

        public void TraceFormat(string format, Exception exception, params object[] args)
        {
            _log.TraceFormat(format, exception, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.TraceFormat(formatProvider, format, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _log.TraceFormat(formatProvider, format, exception, args);
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Trace(formatMessageCallback);
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Trace(formatMessageCallback, exception);
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Trace(formatProvider, formatMessageCallback);
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Trace(formatProvider, formatMessageCallback, exception);
        }

        public void Debug(object message)
        {
            _log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            _log.Debug(message, exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            _log.DebugFormat(format, args);
        }

        public void DebugFormat(string format, Exception exception, params object[] args)
        {
            _log.DebugFormat(format, exception, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.DebugFormat(formatProvider, format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _log.DebugFormat(formatProvider, format, exception, args);
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Debug(formatMessageCallback);
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Debug(formatMessageCallback, exception);
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Debug(formatProvider, formatMessageCallback);
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Debug(formatProvider, formatMessageCallback, exception);
        }

        public void Info(object message)
        {
            _log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            _log.Info(message, exception);
        }

        public void InfoFormat(string format, params object[] args)
        {
            _log.InfoFormat(format, args);
        }

        public void InfoFormat(string format, Exception exception, params object[] args)
        {
            _log.InfoFormat(format, exception, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.InfoFormat(formatProvider, format, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _log.InfoFormat(formatProvider, format, exception, args);
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Info(formatMessageCallback);
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Info(formatMessageCallback, exception);
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Info(formatProvider, formatMessageCallback);
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Info(formatProvider, formatMessageCallback, exception);
        }

        public void Warn(object message)
        {
            _log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            _log.Warn(message, exception);
        }

        public void WarnFormat(string format, params object[] args)
        {
            _log.WarnFormat(format, args);
        }

        public void WarnFormat(string format, Exception exception, params object[] args)
        {
            _log.WarnFormat(format, exception, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.WarnFormat(formatProvider, format, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _log.WarnFormat(formatProvider, format, exception, args);
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Warn(formatMessageCallback);
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Warn(formatMessageCallback, exception);
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Warn(formatProvider, formatMessageCallback);
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Warn(formatProvider, formatMessageCallback, exception);
        }

        public void Error(object message)
        {
            _log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            _log.Error(message, exception);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _log.ErrorFormat(format, args);
        }

        public void ErrorFormat(string format, Exception exception, params object[] args)
        {
            _log.ErrorFormat(format, exception, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.ErrorFormat(formatProvider, format, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _log.ErrorFormat(formatProvider, format, exception, args);
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Error(formatMessageCallback);
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Error(formatMessageCallback, exception);
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Error(formatProvider, formatMessageCallback);
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Error(formatProvider, formatMessageCallback, exception);
        }

        public void Fatal(object message)
        {
            _log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            _log.Fatal(message, exception);
        }

        public void FatalFormat(string format, params object[] args)
        {
            _log.FatalFormat(format, args);
        }

        public void FatalFormat(string format, Exception exception, params object[] args)
        {
            _log.FatalFormat(format, exception, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.FatalFormat(formatProvider, format, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _log.FatalFormat(formatProvider, format, exception, args);
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Fatal(formatMessageCallback);
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Fatal(formatMessageCallback, exception);
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            _log.Fatal(formatProvider, formatMessageCallback);
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            _log.Fatal(formatProvider, formatMessageCallback, exception);
        }

        public bool IsTraceEnabled
        {
            get { return _log.IsTraceEnabled; }
        }

        public bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return _log.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return _log.IsFatalEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return _log.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return _log.IsWarnEnabled; }
        }
        public static ILog GetLogger(object o)
        {
            return new  Log(o);
        }
        public static ILog GetLogger(Type t)
        {
            return new Log(t);
        }

        public static ILog GetLogger(string  name)
        {
            return new Log(name);
        }

        public static ILog GetLogger<T>() where T:class
        {
            return new Log(typeof(T));
        }

        public static ILog GetLoggerFromContext<TContext>() where TContext : class, ILogContext,new()
        {
            var c = new TContext();
            return c.GetLog();
        }
        public static ILog GetLoggerFromContext() 
        {
            return GetLoggerFromContext<TypeNameLogContext>();
        }


        private static string LogTypeDescriptor(Type t)
        {
            return t.Name;
        }
    }
}
