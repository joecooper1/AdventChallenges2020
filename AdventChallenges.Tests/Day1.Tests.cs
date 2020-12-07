using Xunit;
using Advent.Challenges;
using System;

namespace Prime.UnitTests.Services
{
    public class AdventServices_Day1
    {
        private readonly Day1 _day1;

        public AdventServices_Day1()
        {
            _day1 = new Day1();
        }

        [Fact]
        public void Day1_SumTo2020()
        {
            string input = "1721 979 366 299 675 1456";
            int result = _day1.SumTo2020(input);

            Assert.Equal(514579, result);
        }

        [Fact]
        public void Day1_Sum3To2020()
        {
            string input = "1721 979 366 299 675 1456";
            int result = _day1.Sum3To2020(input);

            Assert.Equal(241861950, result);
        }
    }
}
