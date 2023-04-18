using System.Numerics;

namespace Task16PowerDigitSum
{
    /// <summary>
    /// Calculates indicies
    /// </summary>
    internal class IndicesCalculator
    {
        /// <summary>
        /// Calculates an indicies when given a base number and an index.
        /// </summary>
        /// <param name="baseNumber">The base number.</param>
        /// <param name="index">The index.</param>
        /// <returns>string</returns>
        public static string CalculateIndex(int baseNumber, int index)
        {
            BigInteger result = BigInteger.Pow(baseNumber, index);
            
            return result.ToString();
        }
    }
}
