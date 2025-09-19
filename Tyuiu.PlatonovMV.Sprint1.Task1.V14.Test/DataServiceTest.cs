using Tyuiu.PlatonovMV.Sprint1.Task1.V14.Lib;
namespace Tyuiu.PlatonovMV.Sprint1.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;
            var res = ds.Calculate(a, b ,c);
            Assert.AreEqual(0.8667, res, 0.0001);
            
        }
    }
}
