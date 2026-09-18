using Tyuiu.AksenovFM.Sprint1.Task0.V16.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-7, res);

        }
    }
}