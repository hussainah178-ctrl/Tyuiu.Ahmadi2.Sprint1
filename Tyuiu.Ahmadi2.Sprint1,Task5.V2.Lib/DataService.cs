using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task5.V2
{
    public class DataService :ISprint1Task5V2
    {
        private int fahrenheit;

        public int FahrenheitToСelsius(double temp)
        {
            // Formula: (F - 32) * 5/9
            double celsius = (fahrenheit - 32) * 5 / 9;

            // Convert to integer using Convert class
            return Convert.ToInt32(celsius);
        }
    }
}