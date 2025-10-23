using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task4.V16.Lib
{
    public class DataService : ISprint1Task4V16
    {
        public double Calculate(double x)
        {
            double result = (1 / (x + 4));

            return Math.Round(result, 3);
        }
    }
}