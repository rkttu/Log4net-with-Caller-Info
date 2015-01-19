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
        /// <returns></returns>
        public static CallerInfoLog ObtainLog<T>(this T instance)
        {
            return new CallerInfoLog(LogManager.GetLogger(typeof(T)));
        }

        /// <summary>
        /// Obtains the logger.
        /// </summary>
        /// <param name="typeInfo">The type information.</param>
        /// <returns></returns>
        public static CallerInfoLog ObtainLog(this Type typeInfo)
        {
            return new CallerInfoLog(LogManager.GetLogger(typeInfo));
        }

        /// <summary>
        /// Obtains the log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <returns></returns>
        public static CallerInfoLog ObtainLog(this ILog log)
        {
            return new CallerInfoLog(log);
        }
    }
}
