namespace LeetCodeV2.Daily_Problems
{
    public class SearchInRotatedSortedArray
    {
        //Double pointer technique

        public int Search(int[] nums, int target)
        {           
            int pointerOne = nums.Length / 2 - 1;

            if (pointerOne < 0)
                pointerOne = 0;

            int pointerTwo = nums.Length / 2;

            while (pointerOne >= 0)
            {
                if (target == nums[pointerOne])
                    return pointerOne;

                pointerOne--;
            }

            while(pointerTwo < nums.Length)
            {
                if (target == nums[pointerTwo])
                    return pointerTwo;

                pointerTwo++;
            }

            return -1;
        }
    }
}
