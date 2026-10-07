using Tyuiu.MikhailovVN.Sprint2.Task1.V6.Lib;

namespace Tyuiu.MikhailovVN.Sprint2.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 915;
            int b = 169;
            int c = 174;
            int d = 133;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);


            Console.Title = "Спринт #2 | Выполнил: Михайлов В. Н. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                    *");
            Console.WriteLine("* Выполнил: Михайлов Валерий Николаевич | ИСТНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, False, True, False), при x = 1025, y = 275          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение а = " + a);
            Console.WriteLine("Значение b = " + b);
            Console.WriteLine("Значение c = " + c);
            Console.WriteLine("Значение d = " + d);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
                Console.WriteLine(res[i]);
            {

                Console.ReadKey();
            }
        
        }

    }
}
