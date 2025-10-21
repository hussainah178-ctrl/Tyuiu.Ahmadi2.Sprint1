using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint1.Task4.V16.Lib;

namespace Tyuiu.Ahmadi2.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            // ОЖИДАЕМЫЙ РЕЗУЛЬТАТ для вашей формулы
            // Замените 1.328 на ожидаемый результат вашего расчета
            double wait = 1.328;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}