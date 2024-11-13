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
                case 1: return (n +"Январь"+ g);
                case 2: return (n+"Февраль" + g);
                case 3: return (n + "Март" + g);
                case 4: return (n + "Апрель" + g);
                case 5: return (n + "Май" + g);
                case 6: return (n + "Июнь" + g);
                case 7: return (n + "Июль" + g);
                case 8: return (n + "Август" + g);
                case 9: return (n + "Сентябрь" + g);
                case 10: return (n + "Октябрь" + g);
                case 11: return (n + "Ноябрь" + g);
                case 12: return (n + "Декабрь" + g);
                default: return ("err");
            }

        }
    }
}
