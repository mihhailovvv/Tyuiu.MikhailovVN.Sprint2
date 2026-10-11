
using Tyuiu.MikhailovVN.Sprint2.Task4.V24.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Михайлов В. Н. | Группа: ИСТНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Михайлов Валерий Николаевич | ИСТНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫХ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = service.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат = " + res);

            Console.ReadKey();
        }
    }
}
