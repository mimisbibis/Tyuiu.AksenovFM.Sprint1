using Tyuiu.AksenovFM.Sprint1.Task1.V7.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task1.V7
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
            Console.WriteLine("Задание #1");
            Console.WriteLine("Вариант #7");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, которая вычисляет выражение (5*x)/(y+x)");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            double x, y;
            Console.WriteLine("Ведите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();


        }
    }
}
