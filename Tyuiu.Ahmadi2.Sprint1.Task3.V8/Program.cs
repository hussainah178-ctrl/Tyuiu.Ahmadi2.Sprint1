using System;
using Tyuiu.Ahmadi2.Sprint1.Task3.V8.Lib;
//Написать программу вычисления величины дохода по вкладу. Процентная ставка (% годовых) 
// и время хранения (дней) задаются во время работы программы. Ответ округлите до 3 знаков после запятой.
//Величина вклада (руб.) -> 2500
//Срок вклада (дней) -> 30
//Процентная ставка (годовых) -> 20
//Доход: 41.10 руб.
//Сумма по окончании срока вклада: 2541.10 руб.

namespace Tyuiu.Ahmadi2.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ахмади | АСОиУб 25-1-";
            Console.WriteLine("*************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Ахмади | АСОиУб 25-1                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
            Console.WriteLine("* Процентная ставка и время хранения задаются во время работы программы. *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();

            Console.Write("Величина вклада (руб.) -> ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Срок вклада (дней) -> ");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.Write("Процентная ставка (годовых) -> ");
            double annualRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.CalculateIncome(amount, days, annualRate);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}