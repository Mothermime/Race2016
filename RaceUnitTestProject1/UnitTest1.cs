using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Race2016;

namespace RaceUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Factory.ChooseSovereign("Cupidity");

            Assert.AreEqual(Factory.BackerNumber, 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Factory.ChooseShip("Emerald");

            Assert.AreEqual(Factory.ShipNumber, 2);
        }
    }
}
