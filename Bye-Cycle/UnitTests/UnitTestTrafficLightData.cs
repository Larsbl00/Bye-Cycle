using System;
using Bye_Cycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestTrafficLightData
    {
        [TestMethod]
        public void TestMethodCreateData()
        {
            long activeTime = 10;
            TrafficLightData trafficLightData = new TrafficLightData(activeTime);
            Assert.AreEqual(activeTime, trafficLightData.TotalTimeRain);
        }
    }
}
