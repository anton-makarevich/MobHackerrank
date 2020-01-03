using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestProject1
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
            const string nonPangram = "not pangram";
            const string pangram = "pangram";
            
            var map = new List<char>();
            
            foreach (var character in testString.ToLower()
                .Where(char.IsLetter)
                .Where(character => !map.Contains(character)))
                map.Add(character);
            
            return map.Count<26
                ? nonPangram
                : pangram;
        }
    }
}