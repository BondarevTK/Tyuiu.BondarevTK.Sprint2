using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BondarevTK.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a>b) | (b<a);
            res[1] = (a > b) & (b > a);
            res[2] = (c>d) || (c==a);
            res[3] = (a > b) && (b < a);
            res[4] = !(c<d);
            res[5] = (c>d) ^ (c > d);
            return res;
        }
    }
}
