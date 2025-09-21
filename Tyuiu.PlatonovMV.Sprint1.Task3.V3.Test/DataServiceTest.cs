using Tyuiu.PlatonovMV.Sprint1.Task3.V3.Lib;
namespace Tyuiu.PlatonovMV.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.ParallelepipedVolume(9, 7.5, 5);

            Assert.AreEqual(337.5, result);
        }
    }
}
