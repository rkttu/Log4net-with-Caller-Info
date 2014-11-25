using log4net;
using log4net.Core;
using System;

namespace ClouDeveloper.Log4net.CallerInfo
{
    partial class CallerInfoLog
    {
        /// <summary>
        /// The log
        /// </summary>
        private ILog log;

        /// <summary>
        /// Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsDebugEnabled
        {
            get { return this.log.IsDebugEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is error enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorEnabled
        {
            get { return this.log.IsErrorEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsFatalEnabled
        {
            get { return this.log.IsFatalEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is information enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is information enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsInfoEnabled
        {
            get { return this.log.IsInfoEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is warn enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsWarnEnabled
        {
            get { return this.log.IsWarnEnabled; }
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        public ILogger Logger
        {
            get { return this.log.Logger; }
        }

        /// <summary>
        /// Gets the underlying log object.
        /// </summary>
        /// <value>
        /// The underlying log object.
        /// </value>
        /// <exception cref="System.ArgumentNullException">value</exception>
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
