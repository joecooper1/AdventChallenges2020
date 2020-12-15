using Xunit;
using Advent.Challenges;
using System;
using System.IO;
using System.Text;

namespace Prime.UnitTests.Services
{
    public class AdventServices_Day7
    {
        private readonly Day7 _day7;

        public AdventServices_Day7()
        {
            _day7 = new Day7();
        }

        [Fact]
        public void Day7_NumberOfBags()
        {
            string input = "light red bags contain 1 bright white bag, 2 muted yellow bags. dark orange bags contain 3 bright white bags, 4 muted yellow bags. bright white bags contain 1 shiny gold bag. muted yellow bags contain 2 shiny gold bags, 9 faded blue bags. shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags. dark olive bags contain 3 faded blue bags, 4 dotted black bags. vibrant plum bags contain 5 faded blue bags, 6 dotted black bags. faded blue bags contain no other bags. dotted black bags contain no other bags.";
            string input2 = File.ReadAllText("C:/Users/joeco/Desktop/vscode/unit-testing-using-dotnet-test/text/Day7.Input.txt");
            int result = _day7.NumberOfBags(input);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Day7_NumberOfBags2()
        {
            string input = "shiny gold bags contain 2 dark red bags. dark red bags contain 2 muted yellow bags, 3 royal purple bags. muted yellow bags contain no other bags. royal purple bags contain 1 burnt umber bag. burnt umber bags contain no other bags.";
            string input2 = File.ReadAllText("C:/Users/joeco/Desktop/vscode/unit-testing-using-dotnet-test/text/Day7.Input.txt");
            int result = _day7.NumberOfBags2(input);

            Assert.Equal(18, result);
        }
    }
}
