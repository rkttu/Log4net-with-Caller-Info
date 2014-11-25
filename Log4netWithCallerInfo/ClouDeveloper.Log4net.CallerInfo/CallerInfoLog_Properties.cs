using log4net;
using log4net.Core;
using System;

namespace ClouDeveloper.Log4net.CallerInfo
{
    partial class CallerInfoLog
    {
        private ILog log;

        public bool IsDebugEnabled
        {
            get { return this.log.IsDebugEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return this.log.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return this.log.IsFatalEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return this.log.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return this.log.IsWarnEnabled; }
        }

        public ILogger Logger
        {
            get { return this.log.Logger; }
        }

        public ILog UnderlyingLogObject
        {
            get { return this.log; }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                this.log = value;
            }
        }
    }
}
