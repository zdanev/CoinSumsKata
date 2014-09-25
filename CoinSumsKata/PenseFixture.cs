using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinSumsKata
{
    [TestClass]
    public class PenseFixture
    {
        [TestMethod]
        public void PayOnePenseTest()
        {
            Assert.AreEqual(1, Pense.NumberOfCombinations(1));
        }

        [TestMethod]
        public void PayTwoPenseTest()
        {
            Assert.AreEqual(2, Pense.NumberOfCombinations(2));
        }

        [TestMethod]
        public void PayThreePenseTest()
        {
            Assert.AreEqual(2, Pense.NumberOfCombinations(3));
        }

        [TestMethod]
        public void PayFourPenseTest()
        {
            Assert.AreEqual(3, Pense.NumberOfCombinations(4));
        }

        [TestMethod]
        public void PayFivePenseTest()
        {
            Assert.AreEqual(4, Pense.NumberOfCombinations(5));
        }

        [TestMethod]
        public void PaySixPenseTest()
        {
            Assert.AreEqual(5, Pense.NumberOfCombinations(6));
        }

        [TestMethod]
        public void PaySevenPenseTest()
        {
            Assert.AreEqual(6, Pense.NumberOfCombinations(7));
        }

        [TestMethod]
        public void PayTwoHundredPenseTest()
        {
            Assert.AreEqual(73682, Pense.NumberOfCombinations(200));
        }

        [TestMethod]
        public void TestDenominations()
        {
            Assert.IsTrue(Pense.Denominations.Contains(1));
            Assert.IsTrue(Pense.Denominations.Contains(2));
            Assert.IsTrue(Pense.Denominations.Contains(5));
            Assert.IsTrue(Pense.Denominations.Contains(10));
            Assert.IsTrue(Pense.Denominations.Contains(20));
            Assert.IsTrue(Pense.Denominations.Contains(50));
            Assert.IsTrue(Pense.Denominations.Contains(100));
            Assert.IsTrue(Pense.Denominations.Contains(200));
            Assert.AreEqual(8, Pense.Denominations.Count());
        }
    }
}