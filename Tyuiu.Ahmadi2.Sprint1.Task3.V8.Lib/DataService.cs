using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public string CalculateIncome(double amount, int days, double annualRate)
        {
            // Calculate income: (amount * annualRate * days) / (365 * 100)
            double income = Math.Round((amount * annualRate * days) / (365 * 100), 2);
            double totalAmount = Math.Round(amount + income, 2);

            return $"Доход: {income:F2} руб.\nСумма по окончании срока вклада: {totalAmount:F2} руб.";
        }

        public (double income, double totalAmount) CalculateIncomeValues(double amount, int days, double annualRate)
        {
            double income = Math.Round((amount * annualRate * days) / (365 * 100), 2);
            double totalAmount = Math.Round(amount + income, 2);

            return (income, totalAmount);
        }

        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            throw new NotImplementedException();
        }
    }
}