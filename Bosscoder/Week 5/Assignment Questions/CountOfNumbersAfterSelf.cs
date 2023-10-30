﻿using System;
using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Algorithm
     * Implement a merge sort function.
     * For each element i, the function records the number of elements jumping from i's right to i's left during the merge sort.
     * Merge sort nums, store the number of elements jumping from right to left in result.
     * Alternatively, one can sort the indices with corresponding values in nums.That is to say, we are going to sort list [0, 1, ..., n-1] according to the comparator nums[i]. This helps to track the indices and update result.You can find additional details in the implementations below.
     * Return result.*/
    /*Very difficult , able to understand conceptually, heavy difficulty in code
     Revist and revise*/
    public class CountOfNumbersAfterSelf
    {
        public List<int> countSmaller(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int[] indices = new int[n]; // record the index. we are going to sort this array
            for (int i = 0; i < n; i++)
            {
                indices[i] = i;
            }
            // sort indices with their corresponding values in nums, i.e., nums[indices[i]]
            mergeSort(indices, 0, n, result, nums);
            // change int[] to List to return
            List<int> resultToReturn = new List<int>(n);

            foreach (int i in result)
            {
                resultToReturn.Add(i);
            }
            return resultToReturn;
        }

        private void mergeSort(int[] indices, int left, int right, int[] result, int[] nums)
        {
            if (right - left <= 1)
            {
                return;
            }
            int mid = (left + right) / 2;
            mergeSort(indices, left, mid, result, nums);
            mergeSort(indices, mid, right, result, nums);
            merge(indices, left, right, mid, result, nums);
        }

        private void merge(int[] indices, int left, int right, int mid, int[] result, int[] nums)
        {
            // merge [left, mid) and [mid, right)
            int i = left; // current index for the left array
            int j = mid; // current index for the right array
                         // use temp to temporarily store sorted array
            List<int> temp = new List<int>(right - left);
            while (i < mid && j < right)
            {
                if (nums[indices[i]] <= nums[indices[j]])
                {
                    // j - mid numbers jump to the left side of indices[i]
                    result[indices[i]] += j - mid;
                    temp.Add(indices[i]);
                    i++;
                }
                else
                {
                    temp.Add(indices[j]);
                    j++;
                }
            }
            // when one of the subarrays is empty
            while (i < mid)
            {
                // j - mid numbers jump to the left side of indices[i]
                result[indices[i]] += j - mid;
                temp.Add(indices[i]);
                i++;
            }
            while (j < right)
            {
                temp.Add(indices[j]);
                j++;
            }
            // restore from temp
            for (int k = left; k < right; k++)
            {
                indices[k] = temp[k - left];
            }
        }

    }
}
