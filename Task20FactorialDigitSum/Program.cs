namespace Task20FactorialDigitSum
{
    /// <summary>
    /// Main Program Entry
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler TASK 20 - Factorial Digit Sum \n");

            int givenFactorial;

            Console.WriteLine("Please enter a number to get its factorial: ");

            givenFactorial = Convert.ToInt32(Console.ReadLine()); //Value given by user to calculate
            var calculatedFactorial = FactorialCalculator.CalculateFactorial(givenFactorial); //Function to calculate given factorial

            Console.WriteLine("Given factorial: {0} \nCalculated Value: {1}", givenFactorial, calculatedFactorial);
        }
    }
}