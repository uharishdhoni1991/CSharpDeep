using System;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Approach 
     Three pointer 
     Get max of values corresponding to three pointers, Get minimum corresponding to three pointers, find the exp val
     then find the pointer to increment based on minimum of the three pointer correponding values
    */
    public class MinimizeExpOfThreeSortedArrays
    {
        public int Solve(int[] input1, int[] input2, int[] input3)
        {
            int ans = int.MaxValue;
            int i = 0, j = 0, k = 0;

            while(i < input1.Length && j < input2.Length && k < input3.Length)
            {
                int max = Math.Max(input1[i], Math.Max(input2[j], input3[k]));
                int min = Math.Min(input1[i], Math.Min(input2[j], input3[k]));

                ans = Math.Min(ans, max - min);

                if (min == input1[i])
                    i++;
                else if (min == input2[j])
                    j++;
                else if (min == input3[k])
                    k++;
            }

            return ans;
        }
    }
}
