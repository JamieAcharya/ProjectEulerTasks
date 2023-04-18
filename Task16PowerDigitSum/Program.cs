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

            Console.WriteLine(IndicesCalculator.CalculateIndex(baseNumber, index));
        }
    }
}