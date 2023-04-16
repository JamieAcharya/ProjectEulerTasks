using Task20FactorialDigitSum;

namespace ProjectEulerTasksUnitTests.Task20FactorialDigitSumTests
{
    [TestClass]
    public class SumOfDigitsTests
    {
        [TestMethod]
        public void GetsCorrectSumOfDigits()
        {
            //10! sum = 27
            int testFactorial = 10;
            var calculatedFactorial = FactorialCalculator.CalculateFactorial(testFactorial).ToString();

            var calculatedSum = SumOfDigits.CalculateSumOfDigits(calculatedFactorial);

            Assert.AreEqual(calculatedSum, "27");
        }
    }
}