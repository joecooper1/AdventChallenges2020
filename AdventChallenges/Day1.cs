using System;

namespace Advent.Challenges
{
    public class Day1
    {
        public int SumTo2020(string input)
        {
            int[] intArray = Array.ConvertAll(input.Split(' '), int.Parse);

            int firstInt = 0;
            int secondInt = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] + intArray[j] == 2020)
                    {
                        firstInt = intArray[i];
                        secondInt = intArray[j];
                        break;
                    }
                }
                if (firstInt != 0) break;
            }

            return firstInt * secondInt;
        }

        public int Sum3To2020(string input)
        {
            // Split string into array of ints
            int[] intArray = Array.ConvertAll(input.Split(' '), int.Parse);

            // Declare variables
            int firstInt = 0;
            int secondInt = 0;
            int thirdInt = 0;

            // Loop through each number for all 3 values
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    for (int k = 0; k < intArray.Length; k++)
                    {
                        // Don't do the check if two of the numbers are the same
                        if (intArray[k] == intArray[j] || intArray[k] == intArray[i]) break;
                        
                        // Check if all three add up to 2020
                        if (intArray[i] + intArray[j] + intArray[k] == 2020)
                        {
                            firstInt = intArray[i];
                            secondInt = intArray[j];
                            thirdInt = intArray[k];
                            break;
                        }
                    }
                    if (firstInt != 0) break;
                }
                if (firstInt != 0) break;
            }

            return firstInt * secondInt * thirdInt;
        }
    }
}