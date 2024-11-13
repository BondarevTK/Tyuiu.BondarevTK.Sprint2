using Tyuiu.BondarevTK.Sprint2.Task4.V21.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}
