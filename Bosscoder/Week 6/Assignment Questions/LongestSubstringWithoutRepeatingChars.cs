using System;
using System.Collections.Generic;

namespace Bosscoder.Week_6.Assignment_Questions
{
    /*Approach : Sliding Window + Hashset*/
    public class LongestSubstringWithoutRepeatingChars
    {
        public int Solve(string s)
        {
            HashSet<int> hash = new HashSet<int>();
            int left = 0;
            int maxLength = 0;

            for(int right = 0; right < s.Length; right++)
            {
                if(!hash.Contains(s[right]))
                {
                    hash.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                else
                {
                    while(s[left] != s[right])
                    {
                        hash.Remove(s[left]);
                        left++;
                    }

                    hash.Remove(s[left]);
                    left++;

                    hash.Add(s[right]);
                }
            }

            return maxLength;
        }
    }
}