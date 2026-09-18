using Tyuiu.AksenovFM.Sprint1.Task2.V22.Lib;
namespace Tyuiu.AksenovFM.Sprint1.Task2.V22
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
            Console.WriteLine("Задание #2");
            Console.WriteLine("Вариант #22");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, которая вычисляет выражение (x+y+z)/3b  ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
           int x, y, z;
            Console.WriteLine("Ведите значение x");
            Console.WriteLine("Введите значение x");
            x = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите значение y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение z");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine(ds.CalculateAVGValue(x, y, z));
            Console.ReadKey();
        }
    }
}
