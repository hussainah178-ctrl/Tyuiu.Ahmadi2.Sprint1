using System;
using Tyuiu.Ahmadi2.Sprint1.Task6.V9;

namespace Tyuiu.Ahmadi2.Sprint1.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ахмади | ИИПб-23-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ахмади | ИИПб-23-1                                           *");
            Console.WriteLine("*************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,   *");
            Console.WriteLine("* перенеся их последнюю букву в начало.                                   *");
            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите текст: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*************************");

            DataService ds = new DataService();
            string result = ds.MoveLastLetter(inputText);

            Console.WriteLine($"Преобразованный текст: {result}");
            Console.ReadKey();
        }
    }
}