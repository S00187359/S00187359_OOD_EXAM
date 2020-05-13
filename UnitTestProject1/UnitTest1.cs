using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimranDhillon_S00187359;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Phone ph1 = new Phone();
            float expectedPrice = 220;

            ph1.Price = 200;
            ph1.IncreasePrice(0.10f);

            Assert.AreEqual(expectedPrice, ph1.Price);

        }
    }
}
