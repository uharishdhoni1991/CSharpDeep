namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Dutch National Flag Sln or Three Pointer Approach*/
    public class SortColours
    {
        public void PerformSortColors(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;

            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    swap(nums, low, mid);
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    swap(nums, mid, high);
                    high--;
                }
            }
        }

        public void swap(int[] nums, int indexA, int indexB)
        {
            int c = nums[indexA];
            nums[indexA] = nums[indexB];
            nums[indexB] = c;
        }
    }
}
