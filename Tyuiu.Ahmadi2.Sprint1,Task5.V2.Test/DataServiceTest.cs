using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.Ahmadi2.Sprint1.Task5.V2.Lib;


namespace Tyuiu.Ahmadi2.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFahrenheitToCelsius()
        {
            DataService ds = new DataService();

            // Test case 1: Freezing point (32°F = 0°C)
            Assert.AreEqual(0, ds.FahrenheitToCelsius(32));

            // Test case 2: Boiling point (212°F = 100°C)
            Assert.AreEqual(100, ds.FahrenheitToCelsius(212));

            // Test case 3: Room temperature (68°F = 20°C)
            Assert.AreEqual(20, ds.FahrenheitToCelsius(68));

            // Test case 4: Negative temperature (-40°F = -40°C)
            Assert.AreEqual(-40, ds.FahrenheitToCelsius(-40));
        }
    }
}