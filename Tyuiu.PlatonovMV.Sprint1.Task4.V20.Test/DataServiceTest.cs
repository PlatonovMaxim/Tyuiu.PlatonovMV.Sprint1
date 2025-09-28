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
            double x = 2;
            double y = 3;

            double res = ds.Calculate(x, y);                
            double expected = (1 + x) / Math.Abs(x - Math.Sqrt(2 + y));  

            Assert.AreEqual(Math.Round(expected, 3), Math.Round(res, 3));
        }
    }
}

//// 1+x/|x-√(2+y)| 

