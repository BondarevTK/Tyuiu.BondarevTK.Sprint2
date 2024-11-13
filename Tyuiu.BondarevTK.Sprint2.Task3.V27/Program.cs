using Tyuiu.BondarevTK.Sprint2.Task3.V27.Lib;

namespace Tyuiu.BondarevTK.Sprint2.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(x));

        }
    }
}
