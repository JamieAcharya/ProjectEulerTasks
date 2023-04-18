using System.Diagnostics.Metrics;

namespace Task20FactorialDigitSum
{
    /// <summary>
    /// Calculates the summanation for the digits of a given positive natural number
    /// </summary>
    public class SumOfDigits
    {
        /// <summary>
        /// Function that calculates the digits 
        /// </summary>
        /// <param name="value">A given number.</param>
        /// <returns>string</returns>
        public static string CalculateSumOfDigits(string value)
        {
            //Original - Converted Big Integer to string then iterated over string characters
            int count, result = 0;
            int numbers = value.Length;

            for (count = 0; count < numbers; count++)
            {
                if ((value[count] >= '0') && (value[count] <= '9'))
                {
                    result += (value[count] - '0');
                }
            }

            //int result = value.Sum(x => x - '0'); //'0' ASCII = 48, Sums the digits minus the original length of the string, non-original but interesting implementiation
            //Non-Linq
            //foreach (Char c in BigNumberStr)
            //    Sum += (byte)c;

            // 48 is ascii value of zero
            // remove in one step rather than in the loop
            //Sum -= 48 * BigNumberStr.Length;

            return result.ToString();
        }
    }
}