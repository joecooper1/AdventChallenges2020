using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent.Challenges
{
    public class Day4
    {
        public int ValidatePassports(string input)
        {
            string[] arrayOfPassports = input.Split("  ");

            // All required fields
            string[] requiredFields = { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

            // Variable to hold number of valid passports
            int validPassports = 0;

            // Loop through passports
            for (int i = 0; i < arrayOfPassports.Length; i++)
            {
                string passport = arrayOfPassports[i];
                // Get fields
                string[] passportFields = passport.Split(' ');
                // Make dictionary from fields
                Dictionary<string, string> passportFieldsObj = new Dictionary<string, string>();
                for (int j = 0; j < passportFields.Length; j++)
                {
                    string field = passportFields[j];
                    passportFieldsObj.Add(field.Substring(0, 3), field.Substring(4));
                }

                // Check that all required fields are present
                for (int k = 0; k < requiredFields.Length; k++)
                {
                    if (!passportFieldsObj.ContainsKey(requiredFields[k])) break;
                    else if (k == 6) validPassports++;
                }
            }

            return validPassports;
        }

        public int ValidatePassports2(string input)
        {
            string[] arrayOfPassports = input.Split("  ");

            // All required fields
            string[] requiredFields = { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

            // Variable to hold number of valid passports
            int validPassports = 0;

            // Eye colors
            string[] validEyeColors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

            // Regexes
            string pidMatch = @"^/d{9}$";
            string hclMatch = @"^#[0-9a-f]{6}$";

            // Debugging Logs
            Dictionary<string, Dictionary<string, List<string>>> logs = new Dictionary<string, Dictionary<string, List<string>>>();

            string[] types = { "passed", "failed" };

            foreach (string type in types)
            {
                logs[type] = new Dictionary<string, List<string>>();
                foreach (string field in requiredFields)
                {
                    logs[type][field] = new List<string>();
                }
            }

            // Loop through passports
            for (int i = 0; i < arrayOfPassports.Length; i++)
            {
                string passport = arrayOfPassports[i];
                // Get fields
                string[] passportFields = passport.Split(' ');
                // Make dictionary from fields
                Dictionary<string, string> passportFieldsObj = new Dictionary<string, string>();
                for (int j = 0; j < passportFields.Length; j++)
                {
                    string field = passportFields[j];
                    passportFieldsObj.Add(field.Substring(0, 3), field.Substring(4));
                }

                // Do checks one by one
                if (!passportFieldsObj.ContainsKey("byr")) continue;
                if (Int32.Parse(passportFieldsObj["byr"]) > 2002) continue;
                if (Int32.Parse(passportFieldsObj["byr"]) < 1920) continue;

                if (!passportFieldsObj.ContainsKey("iyr")) continue;
                if (Int32.Parse(passportFieldsObj["iyr"]) > 2020) continue;
                if (Int32.Parse(passportFieldsObj["iyr"]) < 2010) continue;

                if (!passportFieldsObj.ContainsKey("eyr")) continue;
                if (Int32.Parse(passportFieldsObj["eyr"]) > 2030) continue;
                if (Int32.Parse(passportFieldsObj["eyr"]) < 2020) continue;

                if (!passportFieldsObj.ContainsKey("ecl")) continue;
                if (!validEyeColors.Contains(passportFieldsObj["ecl"])) continue;

                if (!passportFieldsObj.ContainsKey("pid")) continue;
                if (Regex.IsMatch(passportFieldsObj["pid"], pidMatch)) continue;
                if (passportFieldsObj["pid"].Length != 9) continue;

                if (!passportFieldsObj.ContainsKey("hcl")) continue;
                if (!Regex.IsMatch(passportFieldsObj["hcl"], hclMatch)) continue;

                if (!passportFieldsObj.ContainsKey("hgt")) continue;
                else
                {
                    int value = Int32.Parse(passportFieldsObj["hgt"].Substring(0, passportFieldsObj["hgt"].Length - 2));

                    if (Regex.IsMatch(passportFieldsObj["hgt"], @"cm$"))
                    {
                        if (value < 150 || value > 193) continue;
                    }
                    else
                    if (Regex.IsMatch(passportFieldsObj["hgt"], @"in$"))
                    {
                        if (value < 59 || value > 76) continue;
                    }
                    else continue;
                }

                // Fill in logs
                foreach (string field in requiredFields)
                {
                    logs["passed"][field].Add(passportFieldsObj[field]);
                }

                validPassports++;
            }

            return validPassports;
        }
    }
}