using Tyuiu.Ahmadi2.Sprint1.Task2.V1.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;


namespace Tyuiu.AhmadiMH.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertKmToMiles_CorrectValue()
        {
            // Arrange
            DataService ds = new DataService();
            int km = 100;
            double expected = 62.176;

            // Act
            double actual = Math.Round(ds.ConvertKmToMiles(km), 3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
