namespace Task07Prime10001st.Validation
{
    /// <summary>
    /// Calculates if a given number is prime and the position of that prime number.
    /// </summary>
    public class PrimeValidation
    {
        /// <summary>
        /// Determins if a number is a prime or not
        /// </summary>
        /// <param name="numberToCheck">The number to check if it is prime</param>
        /// <returns>bool</returns>
        public static bool IsPrime(int numberToCheck)
        {
            if (numberToCheck <= 1)
            {
                return false;
            }

            //A prime is only divisible by itself and one
            for (int i = 2; i <= (numberToCheck/2); i++) //Potential divisor cannot be greater than half of the number
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
