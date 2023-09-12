using System;

namespace Bosscoder.Week_3.Warmup_Questions
{
    public class MaxConsecutiveOnes
    {
        public int GetMaxConsecutiveOnes(int[] arr)
        {
            int currConsOnes = 0;
            int maxConsOnes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 1)
                {
                    currConsOnes++;
                }
                else
                {
                    maxConsOnes = Math.Max(maxConsOnes, currConsOnes);
                    currConsOnes = 0;
                }
            }

            maxConsOnes = Math.Max(maxConsOnes, currConsOnes);
            return maxConsOnes;
        }
    }
}
