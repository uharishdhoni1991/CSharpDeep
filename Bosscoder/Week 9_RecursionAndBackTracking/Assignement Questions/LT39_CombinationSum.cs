using System;
using System.Collections.Generic;

namespace Bosscoder.Week_9_RecursionAndBackTracking.Assignement_Questions
{
    public class LT39_CombinationSum
    {
        public IList<IList<int>> Solve(int[] nums, int target)
        {

            var result = new List<IList<int>>();
            Search(nums, target, 0, 0, new List<int>(), result);
            return result;
        }

        private void Search(int[] candidates, int target, int index, int sum, IList<int> temp, IList<IList<int>> result)
        {
            if (sum == target)
            {
                result.Add(new List<int>(temp));
                return;
            }

            while (sum < target && index < candidates.Length)
            {
                temp.Add(candidates[index]);

                Search(candidates, target, index, sum + candidates[index], temp, result);

                temp.RemoveAt(temp.Count - 1);
                index++;
            }
        }
    }
}