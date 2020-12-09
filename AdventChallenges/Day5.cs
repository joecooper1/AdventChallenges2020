using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent.Challenges
{
    public class Day5
    {
        public int GetSeatNumber(string input)
        {
            string[] arrayOfSeats = input.Split(" ");

            int highestSeatNumber = 0;
            List<int> seatNumbers = new List<int>();

            for (int i = 0; i < arrayOfSeats.Length; i++)
            {
                string seat = arrayOfSeats[i];
                char[] seatCoordsRow = seat.Substring(0, 7).ToCharArray();
                char[] seatCoordsColumn = seat.Substring(7, 3).ToCharArray();

                double row = 64;
                double column = 4;

                for (int j = 0; j < seatCoordsRow.Length; j++)
                {
                    double fraction = 128 / (double)Math.Pow(2, j + 2);
                    char coord = seatCoordsRow[j];
                    if (coord == 'F') row -= fraction;
                    if (coord == 'B') row += fraction;
                }

                for (int k = 0; k < seatCoordsColumn.Length; k++)
                {
                    double fraction = 8 / (double)Math.Pow(2, k + 2);
                    char coord = seatCoordsColumn[k];
                    if (coord == 'R') column += fraction;
                    if (coord == 'L') column -= fraction;
                }

                int roundedRow = (int)Math.Floor(row);
                int roundedColumn = (int)Math.Floor(column);

                int total = roundedRow * 8 + roundedColumn;
                seatNumbers.Add(total);
                if (total > highestSeatNumber) highestSeatNumber = total;
            }

            return highestSeatNumber;
        }

        public int GetSeatNumber2(string input)
        {
            string[] arrayOfSeats = input.Split(" ");

            List<int> seatNumbers = new List<int>();

            for (int i = 0; i < arrayOfSeats.Length; i++)
            {
                string seat = arrayOfSeats[i];
                char[] seatCoordsRow = seat.Substring(0, 7).ToCharArray();
                char[] seatCoordsColumn = seat.Substring(7, 3).ToCharArray();

                double row = 64;
                double column = 4;

                for (int j = 0; j < seatCoordsRow.Length; j++)
                {
                    double fraction = 128 / (double)Math.Pow(2, j + 2);
                    char coord = seatCoordsRow[j];
                    if (coord == 'F') row -= fraction;
                    if (coord == 'B') row += fraction;
                }

                for (int k = 0; k < seatCoordsColumn.Length; k++)
                {
                    double fraction = 8 / (double)Math.Pow(2, k + 2);
                    char coord = seatCoordsColumn[k];
                    if (coord == 'R') column += fraction;
                    if (coord == 'L') column -= fraction;
                }

                int roundedRow = (int)Math.Floor(row);
                int roundedColumn = (int)Math.Floor(column);

                int total = roundedRow * 8 + roundedColumn;
                seatNumbers.Add(total);
            }

            seatNumbers.Sort();

            int missingSeatNumber = 0;

            for (int i = seatNumbers[0]; i < seatNumbers[seatNumbers.Count - 1]; i++)
            {
                if (i != seatNumbers[i] - seatNumbers[0]) 
                { 
                    missingSeatNumber = seatNumbers[i] - 1;
                    break; 
                }
            }

            return missingSeatNumber;
        }
    }
}