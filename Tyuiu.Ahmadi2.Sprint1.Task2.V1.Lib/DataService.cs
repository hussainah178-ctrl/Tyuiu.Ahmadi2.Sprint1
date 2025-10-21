
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        double km;

        

        public double ConvertKmToM(int value)
        {
            double res = Convert.ToDouble(value);
            double w = res * 1.609;
            return w;
        }

        
    }
}
