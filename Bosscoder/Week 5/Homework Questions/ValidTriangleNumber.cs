using System;
using System.Collections.Generic;

namespace Bosscoder.Week_5.Homework_Questions
{
    /*Thus, if we are able to find this right limit value of kkk(indicating the element just 
     * greater than nums[i]+nums[j]nums[i] + nums[j]nums[i]+nums[j]), we can conclude that all the elements in numsnumsnums array
     * in the range (j+1,k−1)(j+1, k-1)(j+1,k−1)(both included) satisfy the required inequality. 
     * Thus, the countcountcount of elements satisfying the inequality will be given by
     * (k−1)−(j+1)+1=k−j−1(k-1) - (j+1) + 1 = k - j - 1(k−1)−(j+1)+1=k−j−1.*/
    /*Revise and Revisit*/
    public class ValidTriangleNumber
    {
        public int GetCount(int[] nums)
        {
            int n = nums.Length;
            int cnt = 0;
            Array.Sort(nums);
            for (int k = n - 1; k >= 0; k--)
            {
                int i = 0;
                int j = k - 1;
                while (i < j)
                {
                    if (nums[i] + nums[j] > nums[k])
                    {
                        cnt += j - i;
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return cnt;
        }
    }
}
