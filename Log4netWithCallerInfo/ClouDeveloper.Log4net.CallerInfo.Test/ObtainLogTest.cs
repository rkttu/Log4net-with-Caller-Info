using NUnit.Framework;
using System;

namespace ClouDeveloper.Log4net.CallerInfo.Test
{
    [TestFixture]
    public sealed class ObtainLogTest
    {
        [Test]
        public void ObtainLoggerTest1()
        {
            var log = this.ObtainLog();

            Assert.That(
                log,
                Is.Not.Null);

            Assert.That(
                log.UnderlyingLogObject,
                Is.Not.Null);

            Assert.That(
                log.UnderlyingLogObject.Logger,
                Is.Not.Null);

            Assert.That(
                log.UnderlyingLogObject.Logger,
                Is.EqualTo(log.Logger));

            Assert.That(
                log.IsDebugEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsDebugEnabled));

            Assert.That(
                log.IsErrorEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsErrorEnabled));

            Assert.That(
                log.IsFatalEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsFatalEnabled));

            Assert.That(
                log.IsInfoEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsInfoEnabled));

            Assert.That(
                log.IsWarnEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsWarnEnabled));
        }

        [Test]
        public void ObtainLoggerTest2()
        {
            var log = typeof(ObtainLogTest).ObtainLog();

            Assert.That(
                log,
                Is.Not.Null);

            Assert.That(
                log.UnderlyingLogObject,
                Is.Not.Null);

            Assert.That(
                log.UnderlyingLogObject.Logger,
                Is.Not.Null);

            Assert.That(
                log.UnderlyingLogObject.Logger,
                Is.EqualTo(log.Logger));

            Assert.That(
                log.IsDebugEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsDebugEnabled));

            Assert.That(
                log.IsErrorEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsErrorEnabled));

            Assert.That(
                log.IsFatalEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsFatalEnabled));

            Assert.That(
                log.IsInfoEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsInfoEnabled));

            Assert.That(
                log.IsWarnEnabled,
                Is.EqualTo(log.UnderlyingLogObject.IsWarnEnabled));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullReferenceTest()
        {
            CallerInfoLog log = new CallerInfoLog(null);
        }
    }
}
