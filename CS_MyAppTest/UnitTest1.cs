using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CS_MyAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {

            // Arrange: Collect the necessary dependencies that code wants to use fot test
            // e.g. Test Data, Instancce of Class, expected result
            int x = 10;
            int y = 20;
            int expected = 30;
            CS_SourceApp.MyDemoClass obj = new CS_SourceApp.MyDemoClass();
            // Act: Actuall calling the method (or unit) taht is to be tested
            var actual = obj.Add(x, y);
            // Assert: Compare the Actual Result with Expceted
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddInputException()
        {
            int x = -9;
            int y = 0;
            string expected = "x and y must be + integer";
            CS_SourceApp.MyDemoClass obj = new CS_SourceApp.MyDemoClass();
            Exception ex = Assert.ThrowsException<Exception>(() => obj.Add(x, y));

            // Assert.AreEqual(expected, ex.Message);

            Assert.IsTrue(ex.Message.Contains(expected));
        }
    }
}
