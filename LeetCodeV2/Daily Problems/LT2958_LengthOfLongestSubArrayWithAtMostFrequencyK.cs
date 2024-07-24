using Bosscoder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeV2.Daily_Problems
{
    public class LT2958_LengthOfLongestSubArrayWithAtMostFrequencyK
    {
        [TimeLimitExceeded]
        public int MaxSubarrayLength(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            int i = 0, j = 1, n = nums.Length, currCount = 1, longestCount = 1;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[nums[0]] = 1;            

            while(i < n)
            {
                if (j != n)
                {
                    if (dict.ContainsKey(nums[j]))
                        dict[nums[j]]++;
                    else
                        dict[nums[j]] = 1;
                }

                if (dict.Any(x => x.Value > k) || j == n)
                {
                    i++;

                    if (i == n - 1)
                        return longestCount;

                    j = i+1;
                    dict = new Dictionary<int, int>();
                    dict[nums[i]] = 1;
                    currCount = 1;
                    continue;
                }
                

                j++;
                currCount++;
                longestCount = Math.Max(currCount, longestCount);
            }

            return longestCount;
        }

        [TimeN]
        public int MaxSubarrayLengthOptimised(int[] nums, int k)
        {
            int n = nums.Length;
            int i = 0, j = 0, ans = 0;
            Dictionary<int, int> mp = new Dictionary<int, int>();
            while (j < n)
            {
                if (mp.ContainsKey(nums[j]))
                    mp[nums[j]]++;
                else
                    mp[nums[j]] = 1;

                while (mp[nums[j]] > k) mp[nums[i++]]--;
                ans = Math.Max(ans, j - i + 1);
                j++;
            }
            return ans;
        }
    }
}
