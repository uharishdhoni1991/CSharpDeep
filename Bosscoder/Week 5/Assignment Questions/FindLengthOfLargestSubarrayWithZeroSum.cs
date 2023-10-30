using System;
using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    public class FindLengthOfLargestSubarrayWithZeroSum
    {
        public int Solve(int[] arr)
        {
            int maxLen = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (dict.ContainsKey(sum))                
                    maxLen = Math.Max(maxLen, i - dict[sum]);                  
                else
                    dict[sum] = i;
            }

            return maxLen;
        }
    }
}
