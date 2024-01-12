using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_9_RecursionAndBackTracking.Homework_Questions
{
    public class CombinationSumII
    {
        public IList<IList<int>> Solve(int[] nums, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> currSet = new List<int>();
            int i = 0;
            int currSum = 0;
            Array.Sort(nums);

            CombinationRecurse(nums, i, currSum, currSet, target, res);

            return (IList<IList<int>>)res;
        }

        private void CombinationRecurse(int[] nums, int start, int currSum, List<int> currSet, int target, IList<IList<int>> res)
        {
            if (currSum == target)
            {
                res.Add(new List<int>(currSet));
                return;
            }

            if (currSum > target)
                return;

            if (start == nums.Length)
                return;

            currSum += nums[start];
            currSet.Add(nums[start]);
            CombinationRecurse(nums, start + 1, currSum, currSet, target, res);
            currSum -= nums[start];
            currSet.RemoveAt(currSet.Count-1);


            while ((start + 1) < nums.Length && nums[start] == nums[start + 1])
                start = start + 1;

            CombinationRecurse(nums, start + 1, currSum, currSet, target, res);
        }
    }
}