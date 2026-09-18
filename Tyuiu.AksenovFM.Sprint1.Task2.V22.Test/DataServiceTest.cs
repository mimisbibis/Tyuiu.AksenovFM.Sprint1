using Tyuiu.AksenovFM.Sprint1.Task2.V22.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 0;
            int y = 0;
            int z = 0;
            var res = ds.CalculateAVGValue(x, y, z);
            Assert.AreEqual(0, res);
        }
    }
}
