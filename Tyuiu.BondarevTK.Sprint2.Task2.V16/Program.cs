using Tyuiu.BondarevTK.Sprint2.Task2.V16.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);

        }
    }
}
