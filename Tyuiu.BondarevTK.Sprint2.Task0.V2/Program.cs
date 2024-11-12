using Tyuiu.BondarevTK.Sprint2.Task0.V2.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 123;
            int y = 123;
            bool [] res = ds.GetCompareOperations(x, y);
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
