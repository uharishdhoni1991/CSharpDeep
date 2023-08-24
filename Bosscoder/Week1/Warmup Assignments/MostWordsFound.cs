using Bosscoder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week1.Warmup_Assignments
{
    [TimeN]
    public sealed class MostWordsFound
    {
        public int FindMostWordsFound(string[] sentences)
        {
            int i = 0;
            int j = 0;
     
            int[] mostWordCountArray = new int[sentences.Count()];         

            while (true)
            {
                if (sentences[i][j] == ' ')
                    mostWordCountArray[i] = mostWordCountArray[i] + 1;

                j++;

                if (j == sentences[i].Length)
                {
                    j = 0;
                    i++;
                }

                if (i == sentences.Length)
                    break;
            }

            return mostWordCountArray.Max() + 1;
        }
    }
}
