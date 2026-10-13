
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MikhailovVN.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            if (n < 0)
            {
                return "Количество месяцев не может быть отрицательным.";
            }

            
            int monthNumber = (n % 12) + 1;

            string monthName = monthNumber switch
            {
                1 => "январь",
                2 => "февраль",
                3 => "март",
                4 => "апрель",
                5 => "май",
                6 => "июнь",
                7 => "июль",
                8 => "август",
                9 => "сентябрь",
                10 => "октябрь",
                11 => "ноябрь",
                12 => "декабрь",
                _ => throw new ArgumentOutOfRangeException("Некорректный номер месяца.")
            };

            return monthName;

        }
    }
}
