using Tyuiu.AksenovFM.Sprint1.Task7.V27.Lib;

namespace Tyuiu.AksenovFM.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = -0.382;
            Assert.AreEqual(wait, res);
        }
    }
}