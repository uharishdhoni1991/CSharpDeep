using Bosscoder.Models;

namespace Bosscoder.Week1.Warmup_Assignments
{
    [TimeN]
    public class ArrayConcatenation
    {
        public int[] GetConcatenation(int[] nums)
        {
            int count = nums.Length;

            int[] ansArray = new int[count * 2];
            int j = 0;

            for(int i = 0; i < ansArray.Length; i++)
            {
                ansArray[i] = nums[j];
                j++;

                if (j == count)
                    j = 0;
            }

            return ansArray;
        }
    }
}