using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent.Challenges
{
    public class Day7
    {
        public int NumberOfBags(string input) {
            string[] arrayOfLines = input.Split(".");

            Dictionary<string, string[]> bags = new Dictionary<string, string[]>();

            List<string> validBags = new List<string>();
            validBags.Add("shiny gold");

            int numberOfValidBags = 0;

            for (int i = 0; i < arrayOfLines.Length - 1; i++)
            {
                string[] line = arrayOfLines[i].Split(" bags contain ");
                string bagColor = line[0].Trim();
                string[] containsBags = line[1].Split(",").Select(bag => bag.Trim()).ToArray();
                bags[bagColor] = containsBags;
            }

            // Loop through bags and find all that can hold 'valid bags', add those to the valid bags list and run again until no more have been added
            for (int i = 0; i < validBags.Count(); i++) {
                string validBag = validBags[i];
                foreach (string bag in bags.Keys)
                {
                    foreach (string innerBag in bags[bag]) {
                        if (innerBag.Contains(validBag)) validBags.Add(bag);
                    }
                }
            }

            numberOfValidBags = validBags.Distinct().Count() - 1;

            return numberOfValidBags;
        }

        public int getNumberOfBags(string color, Dictionary<string, string[]> bags)
        {
            string[] bagsToCheck = bags[color];

            if (bagsToCheck[0] == "no other bags") return 0;

            int total = 0;

            foreach(string line in bagsToCheck)
            {
                int number = Int32.Parse(line.Split(" ")[0]);
                string colorToCheck = Regex.Replace(line, @"[\d-]| bags?", string.Empty).Trim();
                number += number * getNumberOfBags(colorToCheck, bags);
                total += number;
            }

            return total;
        }

        public int NumberOfBags2(string input) 
        {
            string[] arrayOfLines = input.Split(".");

            Dictionary<string, string[]> bags = new Dictionary<string, string[]>();

            for (int i = 0; i < arrayOfLines.Length - 1; i++)
            {
                string[] line = arrayOfLines[i].Split(" bags contain ");
                string bagColor = line[0].Trim();
                string[] containsBags = line[1].Split(",").Select(bag => bag.Trim()).ToArray();
                bags[bagColor] = containsBags;
            }

            return getNumberOfBags("shiny gold", bags);
        }
    }
}