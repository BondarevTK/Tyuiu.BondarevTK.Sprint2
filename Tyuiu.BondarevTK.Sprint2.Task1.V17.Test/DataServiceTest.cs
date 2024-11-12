using Tyuiu.BondarevTK.Sprint2.Task1.V17.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTestMethod1GetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, true, true, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}