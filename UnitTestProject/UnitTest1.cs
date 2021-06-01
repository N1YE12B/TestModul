using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_06_M;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumma()
        {
            //arrange
            double x = 1;
            double y = 2;

            double res = 3;
            //act
            var ex = Summ.Sum(x, y);
            //assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestSubtr()
        {
            //arrange
            double x = 1;
            double y = 2;

            double res = -1;
            //act
            var ex = Subtr.Sub(x, y);
            //assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMulti()
        {
            //arrange
            double x = 1;
            double y = 2;

            double res = 2;
            //act
            var ex = Multi.Mult(x, y);
            //assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestDividing()
        {
            //arrange
            double x = 4;
            double y = 2;

            double res = 2;
            //act
            var ex = Dividing.Div(x, y);
            //assert
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMathPow()
        {
            //arrange
            double x = 2;
            double y = 2;

            double res = 4;
            //act
            var ex = MathPow.Pow(x, y);
            //assert
            Assert.AreEqual(ex, res);
        }
    }
}
