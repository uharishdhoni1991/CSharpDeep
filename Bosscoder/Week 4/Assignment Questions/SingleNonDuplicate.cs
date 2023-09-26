namespace Bosscoder.Week_4.Assignment_Questions
{
   /* Approach
    * Position of the searched element is always even.We can find the position by using binary search.
    * Time complexity: O(log(n) Space complexity: O(1)*/
    public class SingleNonDuplicate
    {
        public int GetSingleNonDuplicate(int[] nums)
        {
            int l = 0, r = nums.Length / 2;
            while (l < r)
            {
                var mid = (l + r) / 2;
                if (nums[mid * 2] == nums[mid * 2 + 1])
                    l = mid + 1;
                else
                    r = mid;
            }

            return nums[l * 2];
        }
    }
}
