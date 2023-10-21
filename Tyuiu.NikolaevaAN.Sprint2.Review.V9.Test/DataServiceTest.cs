using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint2.Review.V9.Lib;

namespace Tyuiu.NikolaevaAN.Sprint2.Review.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double pi = Math.PI;
            double x = pi / 2;
            double y = -0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
