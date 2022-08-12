using ProjectEuler;

namespace UnitTests.ProjectEuler
{

    public class ProblemUnitTests
    {
        [Theory]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        public void MultiplesOf3And5(int value, int expected)
        {
            var result = Problems.MultiplesOf3And5(value);
            Assert.Equal(expected, result);
        }
    }
}