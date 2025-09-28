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
            double wait = 12.708; 
            double res = ds.Calculate(x, y);
            res = Math.Round(res, 3);
            Assert.AreEqual(wait, res, 0.01); 
        }
    }
}

//// 1+x/|x-√(2+y)| 

