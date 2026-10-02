using Tyuiu.AksenovFM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.AksenovFM.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "hello world";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string wait = "hell worl";
            Assert.AreEqual(wait, res);
        }
    }
}