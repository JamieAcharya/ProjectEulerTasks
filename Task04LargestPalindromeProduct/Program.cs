namespace Task04LargestPalindromeProduct
{
    /// <summary>
    /// Main entry point
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler TASK 04 - Largest Palindrome Product\n");
            //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            //Find the largest palindrome made from the product of two 3-digit numbers.

            Console.WriteLine(NumberPalindrome.FindLargestPalindrome());
        }
    }
}