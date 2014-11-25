using log4net.Util;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace ClouDeveloper.Log4net.CallerInfo
{
    partial class CallerInfoLog
    {
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
            return String.Concat("[", callerName, ", ", callerFilePath, ":", callerLineNumber, "]");
        }

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

        private string CreateLogMessage(object message, string callerName, string callerFilePath, int callerLineNumber)
        {
            return String.Concat(
                this.CreateCallerInfoString(callerName, callerFilePath, callerLineNumber), " ",
                this.RenderObjectMessage(message));
        }

        private string CreateLogMessage(IFormatProvider provider, string format, object[] args, string callerName, string callerFilePath, int callerLineNumber)
        {
            return this.CreateLogMessage(
                new SystemStringFormat(provider, format, args),
                callerName, callerFilePath, callerLineNumber);
        }

        private string CreateLogMessage(string format, object[] args, string callerName, string callerFilePath, int callerLineNumber)
        {
            return this.CreateLogMessage(
                new SystemStringFormat(CultureInfo.InvariantCulture, format, args),
                callerName, callerFilePath, callerLineNumber);
        }
    }
}
