using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /**Revisit and Revise*/
    public class ReversePairs
    {
        int count;

        public int GetReversePairsCount(int[] nums)
        {
            count = 0;
            MergeSort(nums, 0, nums.Length - 1);
            return count;
        }

        private void MergeSort(int[] nums, int start1, int end2)
        {
            if (start1 == end2)
            {
                return;
            }

            int end1 = (start1 + end2) / 2;
            int start2 = end1 + 1;

            MergeSort(nums, start1, end1);
            MergeSort(nums, start2, end2);

            int[] temp = new int[end2 - start1 + 1];
            int i = temp.Length - 1;

            for (int j = start2; j <= end2; j++)
            {
                var target = ((long)nums[j]) * 2;
                int searchedIdx = GetGreater(nums, start1, end1, target);

                if (nums[searchedIdx] > target)
                {
                    count = count + end1 - searchedIdx + 1;
                }
            }

            while (start1 <= end1 && start2 <= end2)
            {
                if (nums[end2] < nums[end1])
                {
                    temp[i--] = nums[end1--];
                }
                else
                {
                    temp[i--] = nums[end2--];
                }
            }

            while (start1 <= end1)
            {
                temp[i--] = nums[end1--];
            }

            while (start2 <= end2)
            {
                temp[i--] = nums[end2--];
            }

            i = 0;

            while (i < temp.Length)
            {
                nums[start1 + i] = temp[i++];
            }
        }

        private int GetGreater(int[] nums, int left, int right, long target)
        {
            while (left < right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return right;
        }
    }
}
