using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BondarevTK.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((3 <= x) && (x <= 5) && (3 <= y) && (y <= 7))
            {
                res = true;
            }
            else
            {
                if ((6 <= x) && (x <= 7) && (5 <= y) && (y <= 11))
                {
                    res = true;
                }
                else
                {
                    if ((8 <= x) && (x <= 9) && (6 <= y) && (y <= 8))
                    {
                        res = true;
                    }
                    else
                    {
                        if ((10 <= x) && (x <= 12) && (y == 7))
                        {
                            res = true;
                        }
                        else
                        {
                            if ((13 <= x) && (x <= 14) && (3 <= y) && (y <= 10))
                            {
                                res = true;
                            }
                            else
                            {
                                if ((3 <= x) && (x <= 5) && (y == 11))
                                {
                                    res = true;
                                }
                                else
                                {
                                    if ((x == 3) && (11 <= y) && (y <= 13))
                                    {
                                        res = true;
                                    }
                                    else
                                    {
                                        if ((7 <= x) && (x <= 10) && (y == 12))
                                        {
                                            res = true;

                                        }
                                        else
                                        {
                                            if ((10 <= x) && (x <= 12) && (y == 13))
                                            {
                                                res = true;
                                            }
                                            else
                                            {
                                                res = false;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return res;
            
            
            
           
            
            
            
        }
    }
}
