using System;
using Bye_Cycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestFollowSystem
    {
        FollowSystem system;
        DateTime now;
        string name;

        [TestInitialize]
        public void Init()
        {
            name = "sys";
            now = DateTime.Now;
            system = new FollowSystem(now, name);
        }

        [TestMethod]
        public void TestAddFollowData()
        {
            system.AddData(1, Side.Left);
            DateTime lastUsed = DateTime.Now;
            Assert.AreEqual(system.FollowSystemData[0].Direction, Side.Left);
            Assert.AreEqual(system.FollowSystemData[0].TimeLightsOn, 1);
            Assert.AreEqual(lastUsed, system.LastTimeActive);
        }

        [TestMethod]
        public void TestPreferedSide()
        {
            system.AddData(1, Side.Left);
            system.AddData(1, Side.Right);
            system.AddData(1, Side.Left);
            Assert.AreEqual(Side.Left, system.PreferedSide);
        }

        [TestMethod]
        public void TestCountPassedBikes()
        {
            system.AddData(1, Side.Left);
            system.AddData(1, Side.Left);
            system.AddData(1, Side.Left);
            system.AddData(1, Side.Left);
            Assert.AreEqual(4, system.FollowSystemData.Count);
        }
    }
}
