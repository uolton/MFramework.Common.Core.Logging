using System.Diagnostics;

namespace MFramework.Common.Core.Logging.Contexts
{
    public class TypeNameLogContext:ILogContext
    {
        public ILog GetLog()
        {
            var stackTrace = new StackTrace();

            return Log.GetLogger(stackTrace.GetFrame(2).GetMethod().DeclaringType);
        }
    }
}
