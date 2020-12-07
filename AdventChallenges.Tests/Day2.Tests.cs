using Xunit;
using Advent.Challenges;
using System;

namespace Prime.UnitTests.Services
{
    public class AdventServices_Day2
    {
        private readonly Day2 _day2;

        public AdventServices_Day2()
        {
            _day2 = new Day2();
        }

        [Fact]
        public void Day2_ValidatePasswords()
        {
            string input = "1-3 a: abcde 1-3 b: cdefg 2-9 c: ccccccccc";
            string input2 = "";
            int result = _day2.ValidatePasswords(input + input2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Day2_ValidatePasswords2()
        {
            string input = "1-3 a: abcde 1-3 b: cdefg 2-9 c: ccccccccc";
            string input2 = "";
            int result = _day2.ValidatePasswords2(input + input2);

            Assert.Equal(1, result);
        }
    }
}
