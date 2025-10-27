using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task7.V15.Lib
{
    public class DataService :ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            double x2 = x * x;
            double x3 = x2 * x;
            double numerator = Math.Cos(x3) + 7 * x2;
            double denominator = x3 - 15 * x;
            double fraction = numerator / denominator;
            double result = Math.Abs(x2 - x3) - fraction;
            return Math.Round(result, 3);
        }
    }
}