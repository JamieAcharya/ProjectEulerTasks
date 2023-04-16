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
            //orignial was mod sum method
            int result = value.Sum(x => x - '0'); //'0' ASCII = 48, Sums the digits minus the original length of the string, non-original but interesting implementiation

            return result.ToString();
        }
    }
}