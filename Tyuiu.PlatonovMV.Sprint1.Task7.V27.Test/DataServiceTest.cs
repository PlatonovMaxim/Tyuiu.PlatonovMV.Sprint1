using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint1.Task7.V27.Lib;

namespace Tyuiu.PlatonovMV.Sprint1.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double result = ds.Calculate(x, y);

            double wait = 1.75;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double result = ds.Calculate(x, y);

            double wait = 1.251;
            Assert.AreEqual(wait, result);
        }
    }
}