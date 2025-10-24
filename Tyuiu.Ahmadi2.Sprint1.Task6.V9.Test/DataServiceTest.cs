using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.Ahmadi2.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveLastLetter()
        {
            DataService ds = new DataService();

            // Test case 1: Multiple words
            string input1 = "hello world program";
            string expected1 = "ohell dworl mprogra";
            Assert.AreEqual(expected1, ds.MoveLastLetter(input1));

            // Test case 2: Single word
            string input2 = "test";
            string expected2 = "ttes";
            Assert.AreEqual(expected2, ds.MoveLastLetter(input2));

            // Test case 3: Words with single letter
            string input3 = "a bc d";
            string expected3 = "a cb d";
            Assert.AreEqual(expected3, ds.MoveLastLetter(input3));

            // Test case 4: Empty string
            string input4 = "";
            string expected4 = "";
            Assert.AreEqual(expected4, ds.MoveLastLetter(input4));

            // Test case 5: Multiple spaces
            string input5 = "  multiple   spaces  ";
            string expected5 = "emultipl paces";
            Assert.AreEqual(expected5, ds.MoveLastLetter(input5));
        }
    }
}