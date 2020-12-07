using Xunit;
using Advent.Challenges;

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
            int result = _day1.SumTo2020(1);

            Assert.True(result == 1, "Result should be 1");
        }
    }
}
