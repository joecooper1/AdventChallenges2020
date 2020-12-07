using System;
using System.Linq;

namespace Advent.Challenges
{
    public class Day2
    {
        public int ValidatePasswords(string input)
        {
            string[] arrayOfArguments = input.Split(' ');

            int validPasswords = 0;

            for (int i = 0; i < arrayOfArguments.Length; i += 3)
            {
                string range = arrayOfArguments[i];
                int minRange = Int32.Parse(range.Split('-')[0]);
                int maxRange = Int32.Parse(range.Split('-')[1]);
                char letter = char.Parse(arrayOfArguments[i+1].Remove(1));
                string password = arrayOfArguments[i+2];

                // Number of occurences of letter in password
                int count = password.Count(l => l == letter);

                if (count >= minRange && count <= maxRange) validPasswords++;
            }

            return validPasswords;
        }

        public int ValidatePasswords2(string input)
        {
            string[] arrayOfArguments = input.Split(' ');

            int validPasswords = 0;

            for (int i = 0; i < arrayOfArguments.Length; i += 3)
            {
                string range = arrayOfArguments[i];
                int firstPosition = Int32.Parse(range.Split('-')[0]);
                int secondPosition = Int32.Parse(range.Split('-')[1]);
                char letter = char.Parse(arrayOfArguments[i+1].Remove(1));
                string password = arrayOfArguments[i+2];

                if (password[firstPosition-1] == letter && password[secondPosition-1] != letter) validPasswords++;
                else if (password[firstPosition-1] != letter && password[secondPosition-1] == letter) validPasswords++;
            }

            return validPasswords;
        }
    }
}