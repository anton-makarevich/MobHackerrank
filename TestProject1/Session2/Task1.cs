using System.Linq;
using Xunit;

namespace TestProject1.Session2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog","pangram")]
        [InlineData("We promptly judged antique ivory buckles for the next prize","pangram")]
        [InlineData("We promptly judged antique ivory buckles for the prize","not pangram")]
        public void Test1(string testString, string expected)
        {    
            var result = IsPangram(testString);
            Assert.Equal(expected, result);
        }

        string IsPangram(string testString) {
            return testString.ToLower().Where(char.IsLetter).Distinct().Count() < 26
                ? "not pangram"
                : "pangram";;
        }
    }
}