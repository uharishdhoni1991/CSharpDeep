namespace Bosscoder.Week_4.Assignment_Questions
{
    public class FindPeakElement
    {
        public int FindPeak(int[] nums)
        {
            int L = 0;
            int R = nums.Length - 1;

            while (L < R)
            {
                int M = (L + R) / 2;

                if ((M == L || nums[M] > nums[M - 1]) && (M == R || nums[M] > nums[M + 1]))
                {
                    return M;
                }
                else if (M < R && nums[M] > nums[M + 1])
                {
                    R = M;
                }
                else
                {
                    L = M + 1;
                }
            }

            return L;
        }
    }    
}
