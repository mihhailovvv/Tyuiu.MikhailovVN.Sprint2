
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MikhailovVN.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 5 && x <= 6 && y >= 3 && y <= 12) ||   
                (x >= 9 && x <= 13 && y >= 4 && y <= 12) ||  
                (x >= 7 && x <= 8 && y >= 10 && y <= 12) ||  
                (x == 4 && (y == 4 || y == 11)) ||           
                (x == 7 && y == 4) ||                        
                (x == 8 && y == 6) ||                        
                (x == 14 && y >= 4 && y <= 6))               
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
