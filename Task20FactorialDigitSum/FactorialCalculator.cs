using System.Numerics;

namespace Task20FactorialDigitSum
{
    /// <summary>
    /// Calculates a given factorial
    /// </summary>
    public class FactorialCalculator
    {
        /// <summary>
        /// Function that calculates the given factorial
        /// </summary>
        /// <param name="factorial">A given number that is greater than 0 but less than 101</param>
        /// <returns>BigInteger</returns>
        public static BigInteger CalculateFactorial(int factorial)
        {
            BigInteger result = 1;

            while (factorial != 1)
            {
                result *= factorial;
                factorial--;
            }

            return result;
        }
    }
}