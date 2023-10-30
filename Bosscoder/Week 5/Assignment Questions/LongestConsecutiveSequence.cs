using System;
using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    public class LongestConsecutiveSequence
    {
        public int Solve(int[] arr)
        {
            int maxLen = 0;
            int n = arr.Length;            

            if (n < 2)
                return n;

            HashSet<int> hash = new HashSet<int>();

            foreach(int ele in arr)
            {
                hash.Add(ele);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.Contains(arr[i] - 1))
                {
                    int num = arr[i];
                    int currentStreak = 1;

                    while(hash.Contains(num+1))
                    {
                        num++;
                        currentStreak++;
                    }

                    maxLen = Math.Max(maxLen, currentStreak);
                }
               
            }

            return maxLen;
        }
    }
}
