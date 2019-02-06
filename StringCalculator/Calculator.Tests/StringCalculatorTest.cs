using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void Add_ReceivesEmptyString_ReturnZero()
        {
            string argument = "";
            
            int actaul = StringCalculator.Add(argument);

            Assert.AreEqual(0, actaul);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_ReceivesNull_Throws()
        {
            string argument = null;
            
            int actual = StringCalculator.Add(argument);
        }

        [TestMethod]
        public void Add_ReceivesStringWithTwoNumbers_ReturnSum()
        {
            string arguments = "1,2";

            int actual = StringCalculator.Add(arguments);

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ReceivesStringWithOneNumber_ReturnSum()
        {
            string arguments = "1";

            int actual = StringCalculator.Add(arguments);

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
