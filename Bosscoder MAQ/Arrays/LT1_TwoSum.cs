using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder_MAQ.Arrays
{
    public class LT1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int numToCheck = target - nums[i];

                if (dict.ContainsKey(numToCheck))
                    return new int[] { dict[numToCheck], i };

                if (!dict.ContainsKey(nums[i]))
                    dict[nums[i]] = i;
            }

            return new int[] { -1, -1 };
        }
    }
}
