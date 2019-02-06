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

        [TestMethod]
        public void Add_ReceivesStringWithSeveralNumbers_ReturnSum()
        {
            string argument = "12,1,18";

            int actaul = StringCalculator.Add(argument);

            int expected = 31;

            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void Add_IgnoresVariousNonNumericCharacters_ReturnSum()
        {
            string argument = "12a.sw, ///10, od  ??-=_18";

            int actaul = StringCalculator.Add(argument);

            int expected = 40;

            Assert.AreEqual(expected, actaul);
        }
    }
}
