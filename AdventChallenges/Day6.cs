using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent.Challenges
{
    public class Day6
    {
        public int SumOfAnswers(string input)
        {
            string[] arrayOfAnswerBlocks = input.Split("  ");

            arrayOfAnswerBlocks = arrayOfAnswerBlocks.Select(block => block.Replace(" ", "")).ToArray();

            int sumTotal = 0;

            for (int i = 0; i < arrayOfAnswerBlocks.Length; i++) 
            {
                string answerBlock = arrayOfAnswerBlocks[i];
                sumTotal += answerBlock.Distinct().ToArray().Length;
            }

            return sumTotal;
        }

        public int SumOfAnswers2(string input)
        {
            string[] arrayOfAnswerBlocks = input.Split("  ");

            int sumTotal = 0;

            for (int i = 0; i < arrayOfAnswerBlocks.Length; i++) 
            {
                string answerBlock = arrayOfAnswerBlocks[i];
                string[] arrayOfAnswers = answerBlock.Split(" ");

                string commonAnswers = arrayOfAnswers[0];

                for (int j = 0; j < arrayOfAnswers.Length; j++)
                {
                    string answer = arrayOfAnswers[j];
                    for (int k = 0; k < commonAnswers.Length; )
                    {
                        char letter = commonAnswers[k];
                        if (!answer.Contains(letter)) commonAnswers = commonAnswers.Replace(letter.ToString(), "");
                        else k++;
                    }
                }

                sumTotal += commonAnswers.Length;
            }

            return sumTotal;
        }
    }
}