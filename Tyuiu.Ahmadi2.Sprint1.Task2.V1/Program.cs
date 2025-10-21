using System;
using Tyuiu.Ahmadi2.Sprint1.Task2.V1.Lib;
//Формулировка задания: Известно расстояние в километрах. Вычислить расстояние в милях
//При условии, что 1 миля = 1,609 км. Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.Ahmadi2.Sprint1.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sprint #1 | Task #2 | Variant #1 | Ahmadi M.H.               *";
            Console.WriteLine("************************************************************");
            Console.WriteLine("* Sprint #1 | Task #2 | Variant #1 | Ahmadi M.H.           *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* Условие: Известно расстояние в километрах.               *");
            Console.WriteLine("* Вычислить расстояние в милях (1 миля = 1.609 км).        *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("                                                           *");

            Console.Write("Введите расстояние в километрах:                                *");
            int km = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            double miles = ds.ConvertKmToM(km);

            Console.WriteLine();
            Console.WriteLine($"Расстояние в милях: {miles:F3}                              *");
            Console.ReadKey();
        }
    }
}