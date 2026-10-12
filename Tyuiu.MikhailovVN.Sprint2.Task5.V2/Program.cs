
using System.ComponentModel.Design;
using Tyuiu.MikhailovVN.Sprint2.Task5.V2.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Михайлов В. Н. | Группа: ИСТНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Валерий Николаевич | ИСТНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному месяцу определить, в какую пору года попадает этот месяц.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int nmouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((nmouth < 1) || (nmouth >= 13))
            {
                res = "Ошибка! Введен неверный номер месяца.";
            }
            else
            {
                res = "Время года: " + service.FindMonthSeason(nmouth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
