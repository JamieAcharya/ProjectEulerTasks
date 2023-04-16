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
            /**
             * TODO: Move validation to interface and implement in main
             */
            //Factorial validation to check if numbers are in given range
            if (factorial < 0 || factorial > 100)
            {
                //Basic logger and validation
                Console.WriteLine("Given number: '{0}' was not between 0 and 100!", factorial);
                throw new ArgumentOutOfRangeException("Given number must be between 0 and 100!");
            }

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