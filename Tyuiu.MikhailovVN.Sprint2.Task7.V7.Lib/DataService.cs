
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MikhailovVN.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= 2 - Math.Pow(x, 2)) && (y >= Math.Abs(x)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
