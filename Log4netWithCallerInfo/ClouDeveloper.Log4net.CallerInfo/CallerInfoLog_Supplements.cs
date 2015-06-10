using log4net.Util;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace ClouDeveloper.Log4net.CallerInfo
{
    partial class CallerInfoLog
    {
        /// <summary>
        /// Creates the caller information string.
        /// </summary>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        /// <returns></returns>
        private string CreateCallerInfoString(string callerName, string callerFilePath, int callerLineNumber)
        {
            if (String.IsNullOrWhiteSpace(callerFilePath))
                callerFilePath = "unknown";
            else
            {
                try { callerFilePath = Path.GetFileName(callerFilePath); }
                catch { callerFilePath = "invalid file path"; }
            }

            if (callerLineNumber < 0)
                callerLineNumber = 0;
            if (String.IsNullOrWhiteSpace(callerName))
                callerName = "unknown member";
            if (this.Signature.HasValue)
                return String.Concat("[#", this.Signature.Value.ToString("x"), ", ", callerName, ", ", callerFilePath, ":", callerLineNumber, "]");
            else
                return String.Concat("[", callerName, ", ", callerFilePath, ":", callerLineNumber, "]");
        }

        /// <summary>
        /// Renders the object message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        private string RenderObjectMessage(object message)
        {
            try
            {
                var renderMap = this.log.Logger.Repository.RendererMap;
                StringBuilder buffer = new StringBuilder();

                using (StringWriter writer = new StringWriter(buffer))
                {
                    var renderer = renderMap.Get(message);
                    if (renderer == null || Object.ReferenceEquals(renderer, renderMap.DefaultRenderer))
                        writer.Write((message ?? String.Empty).ToString());
                    else
                        renderer.RenderObject(renderMap, message, writer);
                }

                return buffer.ToString();
            }
            catch
            {
                if (message != null)
                    return message.ToString();
                else
                    return "(null)";
            }
        }

        /// <summary>
        /// Creates the log message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        /// <returns></returns>
        private string CreateLogMessage(object message, string callerName, string callerFilePath, int callerLineNumber)
        {
            return String.Concat(
                this.CreateCallerInfoString(callerName, callerFilePath, callerLineNumber), " ",
                this.RenderObjectMessage(message));
        }

        /// <summary>
        /// Creates the log message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        /// <returns></returns>
        private string CreateLogMessage(IFormatProvider provider, string format, object[] args, string callerName, string callerFilePath, int callerLineNumber)
        {
            return this.CreateLogMessage(
                new SystemStringFormat(provider, format, args),
                callerName, callerFilePath, callerLineNumber);
        }

        /// <summary>
        /// Creates the log message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        /// <returns></returns>
        private string CreateLogMessage(string format, object[] args, string callerName, string callerFilePath, int callerLineNumber)
        {
            return this.CreateLogMessage(
                new SystemStringFormat(CultureInfo.InvariantCulture, format, args),
                callerName, callerFilePath, callerLineNumber);
        }
    }
}
