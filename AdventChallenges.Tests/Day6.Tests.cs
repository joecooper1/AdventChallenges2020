using Xunit;
using Advent.Challenges;
using System;

namespace Prime.UnitTests.Services
{
    public class AdventServices_Day6
    {
        private readonly Day6 _day6;

        public AdventServices_Day6()
        {
            _day6 = new Day6();
        }

        [Fact]
        public void Day6_SumOfAnswers()
        {
            string input = "abc  a b c  ab ac  a a a a  b";
            string input2 = "";
            int result = _day6.SumOfAnswers(input + input2);

            Assert.Equal(11, result);
        }

        [Fact]
        public void Day6_SumOfAnswers2()
        {
            string input = "abc  a b c  ab ac  a a a a  b";
            string input2 = "";
            int result = _day6.SumOfAnswers2(input + input2);

            Assert.Equal(6, result);
        }
    }
}
