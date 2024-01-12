using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Mentorship
{
    public class TwoSum
    {
        //ToDo
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();


            for (int k = 0; k < nums.Length; k++)
            {
                if (!dict.ContainsKey(nums[k]))
                    dict[nums[k]] = new List<int> { k };
                else
                    dict[nums[k]].Add(k);
            }

            //Array.Sort(nums);

            int i = 0;
            int j = nums.Length - 1;

            while (i < j)
            {
                int sum = nums[i] + nums[j];

                if (sum == target)
                {
                    if (nums[i] == nums[j])
                    {

                    }

                    return new int[] {
                        dict[nums[i]][0],
                        dict[nums[j]][0]};
                }
                else if (sum > target)
                    j--;
                else
                    i++;
            }

            return new int[] { -1, -1 };
        }
    }
}
