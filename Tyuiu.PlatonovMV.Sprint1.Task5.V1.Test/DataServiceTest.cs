using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.PlatonovMV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDistanceBetweenDots()
        {
            DataService ds = new DataService();
            int result = ds.DistanceBetweenDots(0, 0, 3, 4);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}