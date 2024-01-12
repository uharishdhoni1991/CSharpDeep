using System;
using System.Collections.Generic;

namespace Bosscoder.Week_9_RecursionAndBackTracking.Assignement_Questions
{
    public class LT90_SubsetsII
    {
        public IList<IList<int>> Solve(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
           
            Array.Sort(nums);
            SubsetRecurse(nums, res, new List<int>(), 0);

            return res;
        }

        private void SubsetRecurse(int[] nums, IList<IList<int>> res, List<int> currSubset, int startIndex)
        {
            res.Add(new List<int>(currSubset));
            int prev = -11;

            for (int i = startIndex; i < nums.Length; i++)
            {
                if (prev == nums[i])
                    continue;

                currSubset.Add(nums[i]);
                SubsetRecurse(nums, res, currSubset, i + 1);
                prev = nums[i];
                currSubset.RemoveAt(currSubset.Count - 1);                
            }
        }
    }
}