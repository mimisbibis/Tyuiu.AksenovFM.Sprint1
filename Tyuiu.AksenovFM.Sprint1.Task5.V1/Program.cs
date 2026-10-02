using Tyuiu.AksenovFM.Sprint1.Task5.V1.Lib;

namespace Tyuiu.AksenovFM.Sprint1.Task5.V1
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
            Console.WriteLine("Задание #5");
            Console.WriteLine("Вариант #1");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу, которая вычисляет выражение (x+y+z)/3b  ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}