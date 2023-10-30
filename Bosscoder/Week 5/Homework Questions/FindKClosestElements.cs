using System;

namespace Bosscoder.Week_5.Homework_Questions
{
    //Revisit and Revise
    public class FindKClosestElements
    {
        public int[] Solve(int[] nums,int k, int x)
        {
            int left = 0, right = nums.Length - 1;
            int[] res = new int[k]; 

            while(right - left >= k)
            {
                if (Math.Abs(x - nums[right]) < Math.Abs(x - nums[left]))
                    left++;
                else
                    right--;
            }

            Array.Copy(nums, left, res, 0, k);
            return res;
        }
    }
}
