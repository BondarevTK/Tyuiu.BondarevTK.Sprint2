using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BondarevTK.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (n)
            {
                case 29:
                    if (m == 2)
                    {
                        m += 1;
                        n = 1;
                    }
                    break;
                case 30:
                    if ((m == 4) || (m == 6) || (m == 9) || (m == 11))
                    {
                        m += 1;
                        n = 1;
                    }
                    break;
                case 31:
                    if ((m == 1) || (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10) || (m == 12))
                    {
                        m += 1;
                        n = 1;
                    }
                    break;

                default:
                    n += 1;
                    break;
            }
            switch (m)
            {
                case 1: return ("0"+n +"."+"01"+"."+ g);
                case 2: return ("0" + n + "." + "02" + "." + g);
                case 3: return ("0" + n + "." + "03" + "." + g);
                case 4: return ("0" + n + "." + "04" + "." + g);
                case 5: return ("0" + n + "." + "05" + "." + g);
                case 6: return ("0" + n + "." + "06" + "." + g);
                case 7: return ("0" + n + "." + "07" + "." + g);
                case 8: return ("0" + n + "." + "08" + "." + g);
                case 9: return ("0" + n + "." + "09" + "." + g);
                case 10: return ("0" + n + "." + "10" + "." + g);
                case 11: return ("0" + n + "." + "11" + "." + g);
                case 12: return ("0" + n + "." + "12" + "." + g);
                default: return ("err");
            }

        }
    }
}
