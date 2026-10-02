using Tyuiu.AksenovFM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.AksenovFM.Sprint1.Task5.V7
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
            Console.WriteLine("Задание #6");
            Console.WriteLine("Вариант #7");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, которая вычисляет выражение (x+y+z)/3b  ");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.WorkWithText(str));

            Console.ReadKey();
        }
    }
}