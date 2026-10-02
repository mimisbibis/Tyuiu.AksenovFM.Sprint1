namespace Tyuiu.AksenovFM.Sprint1.Task4.V4.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            return (1 + x * y) / Math.Abs(x + 2);
        }
    }
}