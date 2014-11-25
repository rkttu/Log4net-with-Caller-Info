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
        public void Debug(object message, Exception exception,
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                message: message,
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Debug(
                renderedMessage,
                exception);
        }

        public void Debug(object message,
            [CallerMemberName] string callerName = default(string),
            [CallerFilePath] string callerFilePath = default(string),
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            string renderedMessage = this.CreateLogMessage(
                message: message,
                callerName: callerName,
                callerFilePath: callerFilePath,
                callerLineNumber: callerLineNumber);
            this.log.Debug(
                renderedMessage);
        }
    }

    partial class CallerInfoLog
    {
        public void DebugFormat(IFormatProvider provider, string format, object[] args,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(IFormatProvider provider, string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16,
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
            this.log.Debug(
                renderedMessage);
        }
    }

    partial class CallerInfoLog
    {
        public void DebugFormat(string format, object[] args,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15,
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
            this.log.Debug(
                renderedMessage);
        }

        public void DebugFormat(string format, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16,
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
            this.log.Debug(
                renderedMessage);
        }
    }
}
