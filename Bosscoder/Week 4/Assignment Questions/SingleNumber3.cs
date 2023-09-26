namespace Bosscoder.Week_4.Assignment_Questions
{
    public class SingleNumber3
    {
        public int[] Process(int[] nums)
        {
            int xor = 0;
            int x = 0;
            int y = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
            }

            int setbit = xor & ~(xor - 1);

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & setbit) == 0)
                    x = x ^ nums[i];
                else
                    y = y ^ nums[i];
            }

            int[] ret = new int[] { x, y };

            return ret;
        }
    }
}
