using System;
using Tyuiu.Ahmadi2.Sprint1.Task5.V2.Lib;

namespace Tyuiu.Ahmadi2.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ахмади | ИИПб-23-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Ахмади | ИИПб-23-1                                           *");
            Console.WriteLine("*************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
            Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому с      *");
            Console.WriteLine("* помощью класса Convert.                                                 *");
            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*************************");

            DataService ds = new DataService();
            int celsius = ds.FahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"Температура в градусах Цельсия: {celsius}°C");
            Console.ReadKey();
        }
    }
}