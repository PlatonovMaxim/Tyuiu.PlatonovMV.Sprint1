using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint1.Task7.V27.Lib;

namespace Tyuiu.PlatonovMV.Sprint1.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_ZeroCase()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0, 0);
            double expected = (Math.Cos(0 * 0) + Math.Sin(0 * 0)) / (Math.Sin(0) + 1) - (0 - 12) / (15 + Math.Cos(0));
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void ValidCalculate_X2Y4()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2, 4);
            double expected = -3.597;
            Assert.AreEqual(expected, res);
        }
    }
}
//   cos^2x + sin^2y     x*y - 12                                      
// z = -------------- - -------------                                     
//       sin y + 1       15 + cos x    
//