using System;
using Tyuiu.Ahmadi2.Sprint1.Task7.V15.Lib;

namespace Tyuiu.Ahmadi2.Sprint1.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("*************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            double result = ds.Calculate(x);
            Console.WriteLine($"Ответ: {result}");

            Console.ReadKey();
        }
    }
}