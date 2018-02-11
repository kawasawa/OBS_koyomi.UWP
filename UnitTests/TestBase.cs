using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Koyomi.Common;

namespace UnitTests
{
    [TestClass]
    public abstract class TestBase
    {
        [TestInitialize]
        public virtual void Initilize()
        {
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
        }

        public void LongTimeLoopAction(Action<DateTime> action)
        {
            this.LongTimeLoopAction(action, SystemValues.LOWER_DATE, SystemValues.UPPER_DATE);
        }

        public void LongTimeLoopAction(Action<DateTime> action, DateTime lowerDate, DateTime upperDate)
        {
            if (upperDate < lowerDate)
            {
                throw new ArgumentException($"{nameof(upperDate)} には {nameof(lowerDate)} 以降の日付を指定してください。");
            }

            for (var date = lowerDate; date <= upperDate; date = date.AddDays(1))
            {
                action(date);
            }
        }
    }
}
