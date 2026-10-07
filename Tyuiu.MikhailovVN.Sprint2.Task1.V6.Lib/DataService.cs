using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.MikhailovVN.Sprint2.Task1.V6.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (a < b);
            res[1] = (a != b) & (a == c);
            res[2] = (b < a) || (a <= d);
            res[3] = (c < b) && (b < c);
            res[4] = (d < a) ! || (a <= d);
            res[5] = (c >= b) ^ (c != b);

            return res;
        }
    }
}
