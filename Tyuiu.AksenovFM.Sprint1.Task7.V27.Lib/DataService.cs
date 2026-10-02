using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AksenovFM.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double chislitel = Math.Cos(x * x) + Math.Sin(y * y);
            double znamenatel = Math.Sin(y) + 1;
            double drob1 = chislitel / znamenatel;

            double chislitel2 = x * y - 12;
            double znamenatel2 = 15 + Math.Cos(x);
            double drob2 = chislitel2 / znamenatel2;

            double result = drob1 - drob2;

            return Math.Round(result, 3);
        }
    }
}