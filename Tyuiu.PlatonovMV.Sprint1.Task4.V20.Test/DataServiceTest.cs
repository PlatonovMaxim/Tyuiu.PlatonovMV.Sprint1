using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint1.Task4.V20.Lib;

namespace Tyuiu.PlatonovMV.Sprint1.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;

            double result = ds.Calculate(x, y);
            double expected = 2.549;

            Assert.AreEqual(expected, result);
        }
    }
}

//// 1+x/|x-√(2+y)| 

