using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", "racecar", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("dogod", "dogod", true)]
        [InlineData("mom", "mom", true)]
        [InlineData("dad", "dad", true)]
        [InlineData("donut", "donut", false)]
        public void WordTest(string word, string word2, bool expected)
        {
            //Arrange

            var test = new WordSmith();

            //Act
            bool actualWord = test.IsAPalindrome(word, word2);


            //Assert
            Assert.Equal(expected, actualWord);

        }
    }
}
