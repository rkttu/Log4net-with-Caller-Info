using log4net;
using Moq;
using NUnit.Framework;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace ClouDeveloper.Log4net.CallerInfo.Test
{
    [TestFixture]
    public sealed class LogWarnTest
    {
        private string ObtainCallerName([CallerMemberName] string callerName = default(string))
        { return callerName; }

        private string ObtainCallerFilePath([CallerFilePath] string callerFilePath = default(string))
        { return callerFilePath; }

        [Test]
        public void EmptyCallerInfo()
        {
            Mock<ILog> mock = new Mock<ILog>();
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining("unknown:")
                        .And.StringContaining("unknown member,")
                        .And.StringMatching(":0")
                        .And.StringEnding("Hello, World!"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.Warn("Hello, World!",
                callerName: default(string),
                callerFilePath: default(string),
                callerLineNumber: default(int));
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void SpecialCallerInfoCase1()
        {
            Mock<ILog> mock = new Mock<ILog>();
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining("unknown:")
                        .And.StringContaining("unknown member,")
                        .And.StringMatching(":0")
                        .And.StringEnding("Hello, World!"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.Warn("Hello, World!",
                callerName: default(string),
                callerFilePath: default(string),
                callerLineNumber: default(int) - 1);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void SpecialCallerInfoCase2()
        {
            Mock<ILog> mock = new Mock<ILog>();
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining("invalid file path:")
                        .And.StringContaining("unknown member,")
                        .And.StringMatching(":0")
                        .And.StringEnding("Hello, World!"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.Warn("Hello, World!",
                callerName: default(string),
                callerFilePath: "c:\abb\a.b",
                callerLineNumber: default(int) - 1);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void Message()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World!"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.Warn("Hello, World!");
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void MessageAndException()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>(), It.IsAny<Exception>()))
                .Callback<object, Exception>((x, y) =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World!"));
                    Assert.That(y, Is
                        .Not.Null
                        .And.Property("Message").EqualTo("Surpirse!!"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.Warn("Hello, World!", new Exception("Surpirse!!"));
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg1()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}",
                1);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg2()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}",
                1, 2);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg3()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}",
                1, 2, 3);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg4()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}",
                1, 2, 3, 4);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg5()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}",
                1, 2, 3, 4, 5);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg6()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}",
                1, 2, 3, 4, 5, 6);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg7()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}",
                1, 2, 3, 4, 5, 6, 7);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg8()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.12"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}",
                1, 2, 3, 4, 5, 6, 7, 8.12m);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg9()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.14"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg10()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-22"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22));
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg11()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53));
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg12()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53-9,000"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg13()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53-9,000a"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a');
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg14()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53-9,000ab"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b');
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg15()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53-9,000abcd"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}{14}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b', "cd");
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArg16()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53-9,000abcd123"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}{14}{15}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b', "cd", "123");
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithCultureArgs()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! $1.00$2.00$3.00$4.00$5.00$6.00$7.00$8.123.142014-01-2212:33:53-9,000abcd123&"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                CultureInfo.GetCultureInfo("en-US"),
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}{14}{15}{16}",
                new object[] { 1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b', "cd", "123", '&' });
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg1()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}",
                1);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg2()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}",
                1, 2);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg3()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}",
                1, 2, 3);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg4()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}",
                1, 2, 3, 4);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg5()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}",
                1, 2, 3, 4, 5);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg6()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}",
                1, 2, 3, 4, 5, 6);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg7()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}",
                1, 2, 3, 4, 5, 6, 7);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg8()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.12"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}",
                1, 2, 3, 4, 5, 6, 7, 8.12m);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg9()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.14"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg10()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-22"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22));
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg11()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53));
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg12()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53-9,000"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000);
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg13()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53-9,000a"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a');
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg14()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53-9,000ab"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b');
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg15()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53-9,000abcd"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}{14}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b', "cd");
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArg16()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53-9,000abcd123"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}{14}{15}",
                1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b', "cd", "123");
            Assert.That(invoked, Is.True);
        }

        [Test]
        public void WithoutCultureArgs()
        {
            Mock<ILog> mock = new Mock<ILog>();
            string callerName = this.ObtainCallerName();
            string callerFilePath = Path.GetFileName(this.ObtainCallerFilePath());
            bool invoked = false;

            mock
                .Setup(x => x.Warn(It.IsAny<object>()))
                .Callback<object>(x =>
                {
                    Assert.That(x, Is
                        .Not.Null
                        .And.StringContaining(callerName)
                        .And.StringContaining(callerFilePath)
                        .And.StringMatching(":[0-9]+")
                        .And.StringEnding("Hello, World! \u00a41.00\u00a42.00\u00a43.00\u00a44.00\u00a45.00\u00a46.00\u00a47.00\u00a48.123.142014-01-2212:33:53-9,000abcd123&"));
                    invoked = true;
                });

            CallerInfoLog log = new CallerInfoLog(mock.Object);
            log.WarnFormat(
                "Hello, World! {0:C}{1:C}{2:C}{3:C}{4:C}{5:C}{6:C}{7:C}{8:#0.00}{9:yyyy-MM-dd}{10}{11:#,##0}{12}{13}{14}{15}{16}",
                new object[] { 1, 2, 3, 4, 5, 6, 7, 8.12m, Math.PI, new DateTime(2014, 1, 22), new TimeSpan(12, 33, 53), -9000, 'a', 'b', "cd", "123", '&' });
            Assert.That(invoked, Is.True);
        }
    }
}
