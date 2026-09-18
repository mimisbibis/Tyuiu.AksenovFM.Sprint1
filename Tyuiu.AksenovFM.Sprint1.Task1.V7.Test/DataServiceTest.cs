using Tyuiu.AksenovFM.Sprint1.Task1.V7.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);


        }
    }
}
