using Tyuiu.AksenovFM.Sprint1.Task0.V16.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Аксенов Ф. М. | РППб-26-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Спринт #1");
            Console.WriteLine("Тема: Базовые навыки работы в C#");
            Console.WriteLine("Задание #0");
            Console.WriteLine("Вариант #16");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, которая вычисляет выражение 6/2/3+1-6/2*3");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("6/2/3+1-6/2*3");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
