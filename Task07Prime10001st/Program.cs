namespace Task07Prime10001st
{
    /// <summary>
    /// Main Program Entry
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler TASK 07 - 10001st prime \n");

            Console.WriteLine("Enter '1' to run Prime Position Finder\nEnter '2' to calculate if a number is prime and its position");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Please enter a number to find that positions prime: ");

                int position = Convert.ToInt32(Console.ReadLine());

                _ = new PrimePositionCalculator(); //Won't use the assigned variable so can implement discard

                var calculatedPrime = PrimePositionCalculator.CalculatePrimePosition(position);
                Console.WriteLine("The {0} prime is: {1}", position, calculatedPrime);
            }
            else
            {
                Console.WriteLine("Please enter a number to find if it is a prime and its position: ");
                int position = Convert.ToInt32(Console.ReadLine());
                
                _ = new PrimeCalculator();
                
                var isPrimeandPosition = PrimeCalculator.CalculatePrime(position);
                Console.WriteLine(isPrimeandPosition);            
            }
        }
    }
}