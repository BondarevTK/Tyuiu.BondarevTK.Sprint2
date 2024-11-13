using Tyuiu.BondarevTK.Sprint2.Task7.V15.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));

        }
    }
}
