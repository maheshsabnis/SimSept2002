using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using NUnit;
using NUnit.Framework;
namespace MyClassTesting
{
    /// <summary>
    /// The Class that contains Test Cases
    /// AKA Test Suit
    /// </summary>
    [TestFixture]
    public class MytestClass
    {
        [Test]
        public void AddTest()
        {
            // Arrange: Collect the necessary dependencies that code wants to use fot test
            // e.g. Test Data, Instancce of Class, expected result
            int x = 10;
            int y = 20;
            int expected = 30;
            CS_SourceApp.MyDemoClass obj = new CS_SourceApp.MyDemoClass();
            // Act: Actuall calling the method (or unit) taht is to be tested
            var actual = obj.Add(x,y);
            // Assert: Compare the Actual Result with Expceted
            Assert.AreEqual(expected, actual);
        }
    }
}
