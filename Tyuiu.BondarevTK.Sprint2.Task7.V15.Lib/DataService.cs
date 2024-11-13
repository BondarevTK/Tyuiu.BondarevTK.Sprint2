using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BondarevTK.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = new bool();
            if (((Math.Pow(x, 2) + Math.Pow(y, 2)) >= 1) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 4) && (((x >= 1) && (x <= 2)) || ((x >= -2) && (x <= -1))) && (y >= 1) && (y <= 2))
            {
                res = true;
            }

            else
            {
                res = false;
            }
            return res;
        }
    }
}
