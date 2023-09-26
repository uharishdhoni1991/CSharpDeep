namespace Bosscoder.Week_4.Assignment_Questions
{
    public class FirstLastSortedPosition
    {
        /*Intuition
         * this code should perform two searches:
         * one for finding the left boundary of the target in the sorted array and another for finding the right boundary.
         * 
         * Approach
         * Create two separate binary search functions, lft and rgt, 
         * to find the left and right boundaries of the target. 
         * The lft function finds the leftmost occurrence of the target or the position where
         * it should be inserted. 
         * The rgt function finds the rightmost occurrence of the target or the position where 
         * it should be inserted.
         * The code returns an array containing these positions as the range 
         * where the target appears. If the target is not found, it returns [-1, -1].*/

        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] {
                FigureLeftAndRight(nums, target, true),
                FigureLeftAndRight(nums, target, false) };

            if(result[0] > result[1])
            {
                result[0] = result[1] = -1;
            }

            return result;
        }

        private int FigureLeftAndRight(int[] nums, int target, bool isLeft)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (isLeft ? nums[middle] < target : nums[middle] <= target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return isLeft ? left : right;
        }
    }
}
