using Tyuiu.AksenovFM.Sprint1.Task3.V4.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task3.V4.Test

{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void ValidExpression()
        {
            DataService ds = new DataService();

            double a = 2.75;
            double b = 0.5;
            int c = 7;
            double wait = 22.75;

            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}