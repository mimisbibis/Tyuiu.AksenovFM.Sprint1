using Tyuiu.AksenovFM.Sprint1.Task3.V4.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            ISprint1Task3V4 ds = new ISprint1Task3V4();
            Console.Title = "Спринт #1 | Выполнил: Аксенов Ф. М. | РППб-26-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Спринт #1");
            Console.WriteLine("Тема: Базовые навыки работы в C#");
            Console.WriteLine("Задание #3");
            Console.WriteLine("Вариант #4");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, которая вычисляет выражение (x+y+z)/3b  ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Цена тетради (руб) -> ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Цена обложки (руб) -> ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Количество комплектов (шт) -> ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки: " + ds.Calculate(a, b, c) + " руб");

            Console.ReadKey();
        }
    }
}