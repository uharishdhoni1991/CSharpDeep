using System.Collections.Generic;

namespace Bosscoder.Week_5.Homework_Questions
{
    public class FindKPairsWithSmallestSums
    {
        public List<List<int>> Solve(int[] input1, int[] input2, int k)
        {
            int i = 0, j =0;
            List<List<int>> res = new List<List<int>>();
            
            while(i < input1.Length && j < input2.Length)
            {
                res.Add(new List<int>() {input1[i], input2[j] });

                if (input1[i] < input2[j])
                    j++;
                else
                    i++;
            }

            return res;
        }
    }
}