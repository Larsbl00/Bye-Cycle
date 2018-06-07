using System;
using Bye_Cycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDate
    {
        Date date;
        DateTime now;

        [TestInitialize]
        public void Init()
        {
            date = new Date();
            now = DateTime.Now;
        }

        [TestMethod]
        public void CompareCreatedDateWithCurrentDate()
        {
            Assert.AreEqual(now.DayOfYear, date.GetDate().DayOfYear);
        }
    }
}
