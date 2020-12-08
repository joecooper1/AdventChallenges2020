using Xunit;
using Advent.Challenges;
using System;

namespace Prime.UnitTests.Services
{
    public class AdventServices_Day3
    {
        private readonly Day3 _day3;

        public AdventServices_Day3()
        {
            _day3 = new Day3();
        }

        [Fact]
        public void Day3_MapRoute()
        {
            string input = "..##....... #...#...#.. .#....#..#. ..#.#...#.# .#...##..#. ..#.##..... .#.#.#....# .#........# #.##...#... #...##....# .#..#...#.#";
            string input2 = "";
            int result = _day3.MapRoute(input + input2);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Day3_MapRoute2()
        {
            string input = "..##....... #...#...#.. .#....#..#. ..#.#...#.# .#...##..#. ..#.##..... .#.#.#....# .#........# #.##...#... #...##....# .#..#...#.#";
            string input2 = "";
            long result = _day3.MapRoute2(input + input2);

            Assert.Equal(336, result);
        }
    }
}
