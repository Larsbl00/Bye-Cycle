using System;
using System.Threading;
using Bye_Cycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestTrafficLight
    {
        TrafficLight trafficLight;
        DateTime now;
        string name;

        private void BikePass(int i)
        {
            for (int j = 0; j < i; j++)
            {
                trafficLight.TrafficLightData.Add(new TrafficLightData(i - j));
            }
        }

        [TestInitialize]
        public void Init()
        {
            name = "t-light";
            now = DateTime.Now;
            trafficLight = new TrafficLight(now, name);
        }

        [TestMethod]
        public void SeeIfInitIsCorrect()
        {
            Assert.AreEqual(now, trafficLight.BuildYear);
            Assert.AreEqual(name, trafficLight.Name);
        }

        [TestMethod]
        public void OneBikePassed()
        {
            int bikes = 1;
            BikePass(bikes);
            Assert.AreEqual(bikes, trafficLight.BikesPrioritised);
        }
    }
}
