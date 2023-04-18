namespace Task04LargestPalindromeProduct
{
    /// <summary>
    /// Calculates the largest 3 digit palindrome product
    /// </summary>
    public class NumberPalindrome : PalindromeChecker
    {
        /// <summary>
        /// Find the largest palindrome made from the product of two 3-digit numbers
        /// </summary>
        /// <returns>int</returns>
        public static int FindLargestPalindrome()
        {
            int palindrome = 000;

            for (int i = 999; i >= 100; i--)
            {
                for(int p = i; p > 100; p--)
                {
                    int result = i * p;

                    if(IsPalindrome(result)) 
                    {
                        if(result > palindrome)
                        {
                            palindrome = result;
                        }
                    }
                }
            }

            return palindrome;
        }
    }
}
