using Tyuiu.BondarevTK.Sprint2.Task6.V13.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 9;
            int n = 8;
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, "09.09.2024");
        }
    }
}