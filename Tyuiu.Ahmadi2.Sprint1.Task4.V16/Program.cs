using System;
using Tyuiu.Ahmadi2.Sprint1.Task4.V16.Lib;
//Написать программу, которая запрашивает у пользователя
//исходные данные, вычисляет результат по формуле и печатает 
//его на экране. Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.Ahmadi2.Sprint1.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Ахмади | АСОиУб 25-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Ахмади | АСОиУб 25-1                                           *");
            Console.WriteLine("*************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*************************");

            // Здесь вставьте вашу формулу вместо примера ниже
            // Пример формулы: (1 + Math.Sin(x + y)) / (Math.Abs(x - 2 * y)) 
            double result = ds.Calculate(x); // замените на вашу формулу

            Console.WriteLine(Math.Round(result, 3));

            Console.ReadKey();
        }
    }
}