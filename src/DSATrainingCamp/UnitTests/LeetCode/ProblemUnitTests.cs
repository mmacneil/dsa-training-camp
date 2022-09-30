using LeetCode;

namespace UnitTests.LeetCode
{
    public class ProblemUnitTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 3, 3, 4, 5, 5, 6 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicates(int[] numbers, int expected)
        {
            var result = Problems.RemoveDuplicates(numbers);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1, 0)]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        public void RemoveElement(int[] numbers, int value, int expected)
        {
            var result = Problems.RemoveElement(numbers, value);
            Assert.Equal(expected, result);
        }
    }
}