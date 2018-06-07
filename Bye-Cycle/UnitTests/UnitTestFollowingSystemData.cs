using System;
using Bye_Cycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestFollowingSystemData
    {
        [TestMethod]
        public void TestMethodCreateFollowData()
        {
            FollowSystemData data = new FollowSystemData(1, Side.Unknown);
            Assert.AreEqual(Side.Unknown, data.Direction);
            Assert.AreEqual(1, data.TimeLightsOn);
        }
    }
}
