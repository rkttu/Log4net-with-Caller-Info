using log4net;
using System;

namespace ClouDeveloper.Log4net.CallerInfo
{
    /// <summary>
    /// CallerInfoLogHelper
    /// </summary>
    public static class CallerInfoLogHelper
    {
        /// <summary>
        /// Obtains the logger.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="enableSignature">if set to <c>true</c> [enable signature].</param>
        /// <returns></returns>
        public static CallerInfoLog ObtainLog<T>(
            this T instance,
            bool enableSignature = false)
        {
            return new CallerInfoLog(
                LogManager.GetLogger(typeof(T)),
                enableSignature);
        }

        /// <summary>
        /// Obtains the logger.
        /// </summary>
        /// <param name="typeInfo">The type information.</param>
        /// <param name="enableSignature">if set to <c>true</c> [enable signature].</param>
        /// <returns></returns>
        public static CallerInfoLog ObtainLog(
            this Type typeInfo,
            bool enableSignature = false)
        {
            return new CallerInfoLog(
                LogManager.GetLogger(typeInfo),
                enableSignature);
        }

        /// <summary>
        /// Obtains the log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="enableSignature">if set to <c>true</c> [enable signature].</param>
        /// <returns></returns>
        public static CallerInfoLog ObtainLog(
            this ILog log,
            bool enableSignature = false)
        {
            return new CallerInfoLog(log, enableSignature);
        }
    }
}
