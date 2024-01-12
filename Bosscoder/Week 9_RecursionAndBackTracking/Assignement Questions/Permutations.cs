using System.Collections.Generic;

namespace Bosscoder.Week_9_RecursionAndBackTracking
{
    public class Permutations
    {
        public IList<IList<int>> Solve(List<int> nums)
        {
            var permutations = new List<IList<int>>();
            Permutate(nums, new List<int>(), permutations);
            return permutations;
        }
            
        private void Permutate(List<int> choices, List<int> workingSet, List<IList<int>> result)
        {
            if (choices.Count == 0)
                result.Add(new List<int>(workingSet));

            for(int i =0; i < choices.Count; i++)
            {
                var val = choices[i];
                choices.RemoveAt(i);
                workingSet.Add(val);
                Permutate(choices, workingSet, result);
                choices.Insert(i, val);
                workingSet.Remove(val);
            }
        }
    }
}
