using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double CalculateIncome(double amount, int days, double annualRate)
        {
            // Calculate income: (amount * annualRate * days) / (365 * 100)
            double income = Math.Round((amount * annualRate * days) / (365.0 * 100.0), 3);
            double totalAmount = Math.Round(amount + income, 3);
            
            return income;
        }

        public (double income, double totalAmount) CalculateIncomeValues(double amount, int days, double annualRate)
        {
            double income = Math.Round((amount * annualRate * days) / (365.0 * 100.0), 3);
            double totalAmount = Math.Round(amount + income, 3);

            return (income, totalAmount);
        }

        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            throw new NotImplementedException();
        }
    }
}