using Tyuiu.PlatonovMV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.PlatonovMV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckHelloExists()
        {
            DataService ds = new DataService();
            string value = "Hello world!";
            bool result = ds.CheckHello(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckHelloLowerCaseExists()
        {
            DataService ds = new DataService();
            string value = "hello my name is Max";
            bool result = ds.CheckHello(value);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckHelloNotExists()
        {
            DataService ds = new DataService();
            string value = "Hi world!";
            bool result = ds.CheckHello(value);
            Assert.IsFalse(result);
        }
    }
}