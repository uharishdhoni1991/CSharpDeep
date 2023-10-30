using System;
using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    public class UglyNumber2
    {
        /*Three pointer technique*/
        public int NthUglyNumber(int n)
        {
            int p = 0, q = 0, r = 0;
            int[] nums = new int[n];

            nums[0] = 1;

            for(int i =1; i < n; i++)
            {
                nums[i] = Min(new int[] { nums[p] * 2, nums[q] * 3, nums[r] * 5 });

                if (nums[i] == nums[p]*2)
                    p++;
                if (nums[i] == nums[q]*3)
                    q++;
                if (nums[i] == nums[r]*5)
                    r++;
            }

            return nums[n - 1];
        }

        private int Min(int[] vs)
        {
            int min = int.MaxValue;

            foreach(int n in vs)
            {
                min = Math.Min(min, n);
            }

            return min;
        }
    }
}
