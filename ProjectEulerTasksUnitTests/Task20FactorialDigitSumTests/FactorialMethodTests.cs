using Task20FactorialDigitSum;

namespace ProjectEulerTasksUnitTests.Task20FactorialDigitSumTests
{
    [TestClass]
    public class FactorialMethodTests
    {
        [TestMethod]
        public void GetsCorrectFactorial()
        {
            //10! = 3628800
            int testFactorial = 10;
            var calculateFactorial = FactorialCalculator.CalculateFactorial(testFactorial);

            Assert.AreEqual(calculateFactorial, 3628800);
        }

        [TestMethod]
        public void ValidFactorialRange()
        {
            /**
             * TODO: Implement test method
             */
        }

        [TestMethod]
        public void InvalidFactorialRange()
        {
            /**
             * TODO: Implement test method
             */
        }
    }
}