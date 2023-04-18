using Task07Prime10001st.Validation;

namespace Task07Prime10001st
{
    /// <summary>
    /// Calculates the the prime position
    /// </summary>
    public class PrimePositionCalculator : PrimeValidation
    {
        private readonly static List<int> primeList = new();

        /// <summary>
        /// Method that calculates the prime of a given position in the prime set
        /// </summary>
        /// <param name="position">The poisition of the prime number to calculate</param>
        /// <returns>int</returns>
        public static int CalculatePrimePosition(int position)
        {
            for (int i = 0; position > primeList.Count; i++)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                }
            }

            return primeList.Last();
        }
    }
}


