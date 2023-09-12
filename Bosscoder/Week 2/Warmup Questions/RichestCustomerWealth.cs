using System;

namespace Bosscoder.Week_2.Warmup_Questions
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {

            int i = 0;
            int j = 0;
            int currSum = 0;
            int maxSum = 0;

            while (i < accounts.Length)
            {
                currSum += accounts[i][j];
                j++;

                if (j == accounts[i].Length)
                {
                    maxSum = Math.Max(currSum, maxSum);
                    currSum = 0;
                    j = 0;
                    i++;
                }
            }

            return maxSum;
        }
    }
}
