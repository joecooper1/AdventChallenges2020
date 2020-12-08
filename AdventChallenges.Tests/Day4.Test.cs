using Xunit;
using Advent.Challenges;
using System;

namespace Prime.UnitTests.Services
{
    public class AdventServices_Day4
    {
        private readonly Day4 _day4;

        public AdventServices_Day4()
        {
            _day4 = new Day4();
        }

        [Fact]
        public void Day4_ValidatePassports()
        {
            string input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm  iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884 hcl:#cfa07d byr:1929  hcl:#ae17e1 iyr:2013 eyr:2024 ecl:brn pid:760753108 byr:1931 hgt:179cm  hcl:#cfa07d eyr:2025 pid:166559648 iyr:2011 ecl:brn hgt:59in";
            string input2 = "";
            int result = _day4.ValidatePassports(input + input2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Day4_ValidatePassports2()
        {
            string input = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm  iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884 hcl:#cfa07d byr:1929  hcl:#ae17e1 iyr:2013 eyr:2024 ecl:brn pid:760753108 byr:1931 hgt:179cm  hcl:#cfa07d eyr:2025 pid:166559648 iyr:2011 ecl:brn hgt:59in";
            string input2 = "";
            int result = _day4.ValidatePassports2(input + input2);

            Assert.Equal(2, result);
        }
    }
}
