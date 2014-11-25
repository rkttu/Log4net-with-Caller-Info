using log4net;
using System;

namespace ClouDeveloper.Log4net.CallerInfo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallerInfoLog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallerInfoLog"/> class.
        /// </summary>
        /// <param name="log">The log.</param>
        public CallerInfoLog(ILog log)
            : base()
        {
            this.UnderlyingLogObject = log;
        }

        /// <summary>
        /// 
        /// </summary>
        public sealed class ParameterBarrier
        {
            /// <summary>
            /// Prevents a default instance of the <see cref="ParameterBarrier"/> class from being created.
            /// </summary>
            /// <exception cref="System.NotSupportedException"></exception>
            [Obsolete("This class is not designed for instantiation.", true)]
            private ParameterBarrier() { throw new NotSupportedException(); }
        }
    }
}
