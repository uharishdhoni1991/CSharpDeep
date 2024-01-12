using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_9_RecursionAndBackTracking
{
    public class PermutationsII
    {
        private List<IList<int>> _result;

        public IList<IList<int>> Solve(int[] nums)
        {
            _result = new List<IList<int>>();           
            Permute(nums, 0);
            return _result;
        }

        private void Permute(int[] nums, int pos)
        {
            if (pos == nums.Length - 1)
            {
                _result.Add(nums.ToArray());
                return;
            }

            HashSet<int> set = new HashSet<int>();

            for(int i = pos; i < nums.Length; i++)
            {
                if (!set.Add(nums[i]))
                    continue;

                //Swap
                (nums[i], nums[pos]) = (nums[pos], nums[i]);
                Permute(nums, pos + 1);
                //Swap
                (nums[i], nums[pos]) = (nums[pos], nums[i]);
            }
        }        
    }
}
