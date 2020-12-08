using System;
using System.Linq;

namespace Advent.Challenges
{
    public class Day3
    {
        public int MapRoute(string input)
        {
            // Split string into smaller strings
            string[] arrayOfMap = input.Split(' ');

            // Get width of small string
            int width = arrayOfMap[0].Length;

            // Setup count for trees
            int treeCount = 0;

            // j represents column, so should increase by 3 each time, looping if exceeding the width
            int j = 0;

            for (int i = 1; i < arrayOfMap.Length; i++)
            {
                // i represents row, so should increase by one each time
                j += 3;
                if (j >= width) j -= width;

                // Check position
                if (arrayOfMap[i][j] == '#') treeCount++;
            }

            return treeCount;
        }

        public long MapRoute2(string input)
        {
            // Array of slopes
            int[][] arrayOfSlopes =
            {
                new int[] {1, 1},
                new int[] {3, 1},
                new int[] {5, 1},
                new int[] {7, 1},
                new int[] {1, 2}
            };

            // Split string into smaller strings
            string[] arrayOfMap = input.Split(' ');

            // Get width of small string
            int width = arrayOfMap[0].Length;

            // Setup final total
            long treeCountMultiplied = 1;

            // Loop through arrayOfSlopes
            for (int k = 0; k < arrayOfSlopes.Length; k++)
            {
                int slopeHeight = arrayOfSlopes[k][1];
                int slopeWidth = arrayOfSlopes[k][0];

                int treeCount = 0;
                
                // j represents column, so should increase by 3 each time, looping if exceeding the width
                int j = 0;

                for (int i = 0; i < arrayOfMap.Length;)
                {
                    // i represents row, so should increase by one each time
                    i += slopeHeight;
                    // Check that i is not too high
                    if (i >= arrayOfMap.Length) break;

                    j += slopeWidth;
                    if (j >= width) j -= width;

                    // Check position
                    if (arrayOfMap[i][j] == '#') treeCount++;
                }

                treeCountMultiplied *= treeCount;
            }

            return treeCountMultiplied;
        }
    }
}