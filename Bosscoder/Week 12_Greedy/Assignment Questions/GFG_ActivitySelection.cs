using System;
using System.Collections.Generic;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class GFG_ActivitySelection
    {
        public IList<int> Solve(int[] input1, int[] input2)
        {
            List<int> res = new List<int>();

            int n = input1.Length;

            int i = 0;
            int j;

            res.Add(i);

            for (j = 1; j < n; j++)
            {
                if (input1[j] >= input2[i])
                {
                    res.Add(j);
                    i = j;
                }                               
            }

            return res;
        }  
    }
}