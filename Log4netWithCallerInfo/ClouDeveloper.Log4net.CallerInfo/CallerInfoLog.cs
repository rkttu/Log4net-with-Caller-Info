using log4net;
using System;

namespace ClouDeveloper.Log4net.CallerInfo
{
    public sealed partial class CallerInfoLog
    {
        public CallerInfoLog(ILog log)
            : base()
        {
            this.UnderlyingLogObject = log;
        }

        public sealed class ParameterBarrier
        {
            [Obsolete("This class is not designed for instantiation.", true)]
            private ParameterBarrier() { throw new NotSupportedException(); }
        }
    }
}
