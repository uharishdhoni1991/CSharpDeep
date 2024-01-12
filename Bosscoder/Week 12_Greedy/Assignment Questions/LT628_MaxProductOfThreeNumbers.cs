using Bosscoder.Models;
using System;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class LT628_MaxProductOfThreeNumbers
    {
        [TimeNLogN]
        public int MaximumProduct(int[] nums)
        {
            int maxProductPositiveNums = 1;
            int maxProductNegativeNums = 1;

            Array.Sort(nums);

            for(int i = nums.Length-1; i > nums.Length-4 && i >= 0; i--)
            {
                maxProductPositiveNums *= nums[i];
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (i < 2 || i == nums.Length - 1)
                    maxProductNegativeNums *= nums[i];
            }

            return Math.Max(maxProductPositiveNums, maxProductNegativeNums);
        }

        [TimeN]
        public int maximumProduct(int[] nums)
        {
            int min1, min2, max1, max2, max3;
            min1 = min2 = int.MaxValue;
            max1 = max2 = max3 = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                //Updating maximums
                if (max1 < nums[i])
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (max2 < nums[i])
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (max3 < nums[i])
                {
                    max3 = nums[i];
                }

                //Updating minimums
                if (min1 > nums[i])
                {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (min2 > nums[i])
                {
                    min2 = nums[i];
                }

            }

            return Math.Max(max1 * max2 * max3, min1 * min2 * max1);
        }
    }
}
