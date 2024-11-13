using Tyuiu.BondarevTK.Sprint2.Task4.V21.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 1);
            Assert.AreEqual(0.905, res);
        }
    }
}