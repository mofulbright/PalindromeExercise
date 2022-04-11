using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("morgan", false)]
        [InlineData("spectacular", false)]
        [InlineData("reviver", true)]
        public void Test1(string word, bool expected)
        {
            WordSmith palindromeTest = new WordSmith();

            var actual = palindromeTest.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
