using Tyuiu.BondarevTK.Sprint2.Task7.V15.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 1.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, false);
        }
    }
}