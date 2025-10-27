using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint1.Task7.V15.Lib;

namespace Tyuiu.Ahmadi2.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 0.841;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}