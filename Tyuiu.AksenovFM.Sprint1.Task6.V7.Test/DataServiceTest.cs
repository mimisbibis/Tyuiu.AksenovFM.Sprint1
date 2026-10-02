using Tyuiu.AksenovFM.Sprint1.Task6.V7.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class ISprint1Task6V7
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