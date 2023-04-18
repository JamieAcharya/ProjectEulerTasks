using Task20FactorialDigitSum;

namespace Task16PowerDigitSum
{
    /// <summary>
    /// Main Entry Point
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler TASK 16 - Power Digit Sum\n");

            Console.WriteLine("Please enter a base number: ");

            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the index/power: ");

            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your calculated index is: {0} \n", IndicesCalculator.CalculateIndex(baseNumber, index));

            var sumOfDigits = SumOfDigits.CalculateSumOfDigits(IndicesCalculator.CalculateIndex(baseNumber, index)); //sum the digits of the given factorial 

            Console.WriteLine("The sum of the digits of your calculated index is: {0}. \n", sumOfDigits);
        }
    }
}