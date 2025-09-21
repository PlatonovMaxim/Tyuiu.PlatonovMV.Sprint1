using Tyuiu.PlatonovMV.Sprint1.Task2.V29.Lib;
namespace Tyuiu.PlatonovMV.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int result = ds.ConvertSecondsToHours(120);
            Assert.AreEqual(2, result);
        }
    }
}
