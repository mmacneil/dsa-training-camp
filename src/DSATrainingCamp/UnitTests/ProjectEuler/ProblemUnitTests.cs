using ProjectEuler;

namespace UnitTests.ProjectEuler
{

    public class ProblemUnitTests
    {
        [Theory]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        public void MultiplesOf3And5(int ceiling, int expected)
        {
            var result = Problems.MultiplesOf3And5(ceiling);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4000000, 4613732)]
        public void EvenFibonacciNumbers(int ceiling, int expected)
        {
            var result = Problems.EvenFibonacciNumbers(ceiling);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(13195, 29)]
        [InlineData(600851475143, 6857)]
        public void LargestPrimeNumber(long number, int expected)
        {
            var result = Problems.LargestPrimeFactor(number);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LargestPalindromeProduct()
        {
            var result = Problems.LargestPalindromeProduct();
            Assert.Equal(906609, result);
        }

        [Fact]
        public void SmallestMultiple()
        {
            var result = Problems.SmallestMultiple();
            Assert.Equal(232792560, result);
        }

        [Fact]
        public void SumSquareDiffernce()
        {
            var result = Problems.SumSquareDifference();
            Assert.Equal(25164150, result);
        }


        [Fact]
        public void TenThousandFirstPrime()
        {
            var result = Problems.TenThousandFirstPrime();
            Assert.Equal(104743, result);
        }
    }
}