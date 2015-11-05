using log4net;
using System;
using System.Threading;

namespace ClouDeveloper.Log4net.CallerInfo
{
    /// <summary>
    /// CallerInfoLog
    /// </summary>
    public sealed partial class CallerInfoLog
    {
        private static long InternalSignatureCount = 0L;

        /// <summary>
        /// Initializes a new instance of the <see cref="CallerInfoLog" /> class.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="enableSignature">if set to <c>true</c> [enable signature].</param>
        public CallerInfoLog(ILog log, bool enableSignature)
            : base()
        {
            this.UnderlyingLogObject = log;

            if (enableSignature)
                this.Signature = Interlocked.Increment(ref InternalSignatureCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallerInfoLog" /> class.
        /// </summary>
        /// <param name="log">The log.</param>
        public CallerInfoLog(ILog log)
            : this(log, false)
        {
        }

        /// <summary>
        /// Gets or sets the signature.
        /// </summary>
        /// <value>
        /// The signature.
        /// </value>
        public long? Signature
        {
            get;
            private set;
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
