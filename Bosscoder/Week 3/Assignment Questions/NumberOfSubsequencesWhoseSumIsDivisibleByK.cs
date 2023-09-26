using System.Collections.Generic;

namespace Bosscoder.Week_3.Assignment_Questions
{
    public class NumberOfSubsequencesWhoseSumIsDivisibleByK
    {
        public int GetNoOfSequences(int[] nums, int k)
        {
            //Using Prefix Sum Approach
            //Revisit and dry run
            int count = 0;
            Dictionary<int, int> sumCountMap = new Dictionary<int, int>();
            sumCountMap.Add(0, 1);
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                int diff = sum - k;

                if (sumCountMap.ContainsKey(diff))
                {
                    count += sumCountMap[diff];
                }

                if (!sumCountMap.ContainsKey(sum))
                {
                    sumCountMap.Add(sum, 0);
                }

                sumCountMap[sum]++;
            }

            return count;

        }
    }
}