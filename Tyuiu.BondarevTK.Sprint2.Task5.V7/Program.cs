using Tyuiu.BondarevTK.Sprint2.Task5.V7.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.FindMonthName(x, y));
        }
    }
}
