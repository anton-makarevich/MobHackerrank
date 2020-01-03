using System.Linq;
using Xunit;

namespace TestProject1
{
    public class UnitTest2
    {
        [Theory]
        [InlineData("aba",10,7)]
        [InlineData("a",1000000000000,1000000000000)]
        public void Test1(string testString, long times, long expected)
        {    
            var result = CalculateA(testString, times);
            Assert.Equal(expected, result);
        }

        private long CalculateA(string testString, long times)
        {
            if (!testString.Contains("a"))
                return 0;
            var d = times % testString.Length;
            var mod = times / testString.Length;

            var count = testString.Count(f => f == 'a');
            var extraCount = (d>0)? testString.Substring(0, (int)d).Count(f => f == 'a')
                :0;

            return count*mod+extraCount;
        }
    }
}