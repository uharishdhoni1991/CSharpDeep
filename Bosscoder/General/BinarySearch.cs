namespace Bosscoder.General
{
    public class BinarySearch
    {
        public int BS(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;            
            int res = -1;

            if (nums.Length == 1)
                return nums[0] == target ? 0 : -1;

            while (start <= end)
            {
                int m = (start + end) / 2;

                if (nums[m] == target)
                    return m;

                if (nums[m] < target)
                    start = m;

                else
                    end = m;
            }

            return res;
        }
    }
}
