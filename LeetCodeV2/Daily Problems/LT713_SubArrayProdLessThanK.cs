using System;
using System.Collections.Generic;

namespace LeetCodeV2.Daily_Problems
{
    public class LT713_SubArrayProdLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1) return 0;

            int left = 0, right = 0, product = 1, count = 0;
            int n = nums.Length;

            while (right < n)
            {
                product *= nums[right];// Extend the window by including nums[right] in the product
                                       // Shrink the window if product >= k
                while (product >= k) product /= nums[left++]; //we remove left most value from out product
                                                              // and shrink out window 
                count += 1 + (right - left);// product is less so element also less concept
                // Count all subarrays that end at right index and satisfy the condition
                right++;
            }
            return count;
        }
    }
}