using Tyuiu.BondarevTK.Sprint2.Task6.V13.Lib;
namespace Tyuiu.BondarevTK.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.FindDateOfNextDay(x, y, z));
            
        }
    }
}
