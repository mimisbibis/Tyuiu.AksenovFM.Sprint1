namespace Tyuiu.AksenovFM.Sprint1.Task5.V1.Lib
{
    public class DataService
    {
        public double Calculate(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            return distance;
        }
    }
}