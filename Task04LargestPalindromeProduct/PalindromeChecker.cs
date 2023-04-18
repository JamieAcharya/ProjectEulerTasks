namespace Task04LargestPalindromeProduct
{
    /// <summary>
    /// Checks if a given number is a palindrome
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Checks if a number is a palindrome
        /// </summary>
        /// <param name="number">The number to be checked</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(int number)
        {
            char[] chars = number.ToString().ToCharArray();

            Array.Reverse(chars);

            string reverseString = new(chars);

            if (number.ToString() == reverseString)
            {
                return true;
            }

            return false;
        }
    }
}
