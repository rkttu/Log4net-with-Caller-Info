using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClouDeveloper.Log4net.CallerInfo
{
    partial class CallerInfoLog
    {
        /// <summary>
        /// Informations the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void Info(object message, Exception exception,
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                message: message,
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage,
                exception);
        }

        /// <summary>
        /// Informations the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void Info(object message,
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                message: message,
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }
    }

    partial class CallerInfoLog
    {
        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object[] args,
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: args,
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="arg15">The arg15.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="arg15">The arg15.</param>
        /// <param name="arg16">The arg16.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                provider: provider,
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }
    }

    partial class CallerInfoLog
    {
        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object[] args,
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: args,
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="arg15">The arg15.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }

        /// <summary>
        /// Informations the format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="arg15">The arg15.</param>
        /// <param name="arg16">The arg16.</param>
        /// <param name="barrier">The barrier.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <param name="callerFilePath">The caller file path.</param>
        /// <param name="callerLineNumber">The caller line number.</param>
        public void InfoFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16,
            ParameterBarrier barrier = default(ParameterBarrier),
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                format: format,
                args: new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 },
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Info(
                renderedMessage);
        }
    }
}
