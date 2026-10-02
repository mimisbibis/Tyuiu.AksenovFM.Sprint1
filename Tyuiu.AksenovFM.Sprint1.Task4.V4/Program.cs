using Tyuiu.AksenovFM.Sprint1.Task4.V4.Lib;

namespace Tyuiu.AksenovFM.Sprint1.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Аксенов Ф. М. | РППб-26-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Спринт #1");
            Console.WriteLine("Тема: Базовые навыки работы в C#");
            Console.WriteLine("Задание #4");
            Console.WriteLine("Вариант #4");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, по условию задания из таска4");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine("(1 + x * y) / |x + 2| = " + Math.Round(result, 3));

            Console.ReadKey();
        }
    }
}