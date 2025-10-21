using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint1.Task3.V8.Lib;

namespace Tyuiu.Ahmadi2.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double amount = 2500;
            int days = 30;
            double annualRate = 20;

            var result = ds.CalculateIncomeValues(amount, days, annualRate);

            Assert.AreEqual(41.096, result.income, 0.001);
            Assert.AreEqual(2541.096, result.totalAmount, 0.001);
        }
    }
}