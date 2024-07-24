using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT805_SplitArrayWithSameAverage
    {
        Dictionary<string, bool> _hash;

        public bool SplitArraySameAverage(int[] nums)
        {
            _hash = new Dictionary<string, bool>();

            int total = 0, n = nums.Length;

            foreach(var num in nums)
            {
                total += num;
            }
            
            for(int i = 1; i <= nums.Length; i++)
            {
                int quot = (total * i) % n;

                if(quot == 0)
                {
                    int s1 = (total * i) / n;

                    if (CanSplit(s1, i, n, nums))
                        return true;
                }
            }

            return false;
        }

        private bool CanSplit(int sum, int length, int n, int[] nums)
        {
            if (n == 0)
                return sum == 0 && length == 0;            
            else if (length == 0)
                return sum == 0;                           

            if (length == 0)
                return sum == 0;

            if (length >= nums.Length)
                return false;

            string key = $"{ sum }-{ n}-{ length}";

            if (_hash.ContainsKey(key))
                return _hash[key];
         
            bool eitherIncludeOrDont = CanSplit(sum, length, n-1, nums) ||
                CanSplit(sum-nums[length], length - 1, n-1, nums);
            _hash[key] = eitherIncludeOrDont;
            return _hash[key];
        }
    }
}