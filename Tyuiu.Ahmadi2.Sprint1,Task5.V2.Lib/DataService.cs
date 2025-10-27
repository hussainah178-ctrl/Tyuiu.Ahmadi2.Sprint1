using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task5.V2.Lib;

public class DataService : ISprint1Task5V2
{
    public int FahrenheitToCelsius(double fahrenheit)
    {
        // Formula: (F - 32) * 5/9
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Convert to integer using Convert class
        return Convert.ToInt32(celsius);
    }

    public int FahrenheitToСelsius(double temp)
    {
        throw new NotImplementedException();
    }
}
