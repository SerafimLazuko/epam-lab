using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// Static class, contains method Add
    /// </summary>
    public static class StringCalculator
    {
        private static string pattern = @"[\D]";

        /// <summary>
        /// Return sum of numbers in string parameter
        /// </summary>
        /// <param name="argument">The string parameter, contains numbers.</param>
        /// <returns>Return sum of all numbers in parameter </returns>
        /// <exception cref="System.ArgumentNullException">argument</exception>
        public static int Add(string argument)
        {
            if (argument == null)
                throw new ArgumentNullException(nameof(argument));

            string[] elements = Regex.Split(argument, pattern).Where(s => s != String.Empty).ToArray<string>();

            int result = 0;

            int number = 0;

            foreach (var element in elements)
            {
                bool parsed = int.TryParse(element, out number);

                if (parsed)
                    result += number;
            }

            return result;
        } 
    }
}
