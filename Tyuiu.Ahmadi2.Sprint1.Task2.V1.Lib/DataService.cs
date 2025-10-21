
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task2.V1.Lib
{
    public class DataService :ISprint1Task1V1
    {
        private double km;

        public double Calculate(double a, double x, double y)
        {
            return km / 1.609;
        }

        public double ConvertKmToMiles(int km)
        {
            return km / 1.609;
        }
    }
}
