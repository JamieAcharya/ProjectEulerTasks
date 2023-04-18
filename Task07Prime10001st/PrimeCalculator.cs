using Task07Prime10001st.Validation;

namespace Task07Prime10001st
{
    /// <summary>
    /// Calculates if a given number is prime and the position of that prime number.
    /// </summary>
    public class PrimeCalculator : PrimeValidation
    {
        private readonly static List<int> primeList = new();

        /// <summary>
        /// Calculates if a number is prime and the position of that number in the prime set
        /// </summary>
        /// <param name="primeNumber">The number to check if it is prime</param>
        /// <returns>string</returns>
        public static string CalculatePrime(int primeNumber)
        {
            string result;

            if(!IsPrime(primeNumber))
            {
                result = $"{primeNumber} is not prime!";

                return result;
            }
            else
            {
                for (int i = 0; i < primeNumber; i++)
                {
                    if (IsPrime(i))
                    {
                        primeList.Add(i);
                    }
                }

                var position = primeList.Count + 1;
                result = $"{primeNumber} is prime! with a position of: {position}";

                return result;
            }
        }
    }
}

