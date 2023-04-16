namespace Task20FactorialDigitSum
{
    /// <summary>
    /// Main Program Entry
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int givenFactorial;
            string sumOfDigits;

            Console.WriteLine("Project Euler TASK 20 - Factorial Digit Sum \n");

            Console.WriteLine("Please enter a number between 0 and 100 to get its factorial: ");

            givenFactorial = Convert.ToInt32(Console.ReadLine()); //Value given by user to calculate

            var calculatedFactorial = FactorialCalculator.CalculateFactorial(givenFactorial); //Function to calculate given factorial

            Console.WriteLine("\nGiven factorial: {0} \nCalculated Value: {1} \n", givenFactorial, calculatedFactorial);

            sumOfDigits = SumOfDigits.CalculateSumOfDigits(calculatedFactorial.ToString()); //sum the digits of the given factorial 

            Console.WriteLine("The sum of the digits of your given factorial is: {0}. \n", sumOfDigits);
        }
    }
}