
using Tyuiu.MikhailovVN.Sprint2.Task6.V7.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Михайлов В. Н. | Группа: ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Валерий Николаевич | ИСТНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца этого дня с помощью сокращенного switch.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int startYear = 1990;
            Console.WriteLine("Начальный год: " + startYear);

            Console.Write("Введите количество прошедших месяцев (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (n < 0)
            {
                Console.WriteLine("Ошибка! Количество месяцев не может быть отрицательным.");
            }
            else
            {
                string res = ds.FindMonthName(startYear, n);
                Console.WriteLine("Название месяца: " + res);
            }

            Console.ReadKey();
        }
    }
}
