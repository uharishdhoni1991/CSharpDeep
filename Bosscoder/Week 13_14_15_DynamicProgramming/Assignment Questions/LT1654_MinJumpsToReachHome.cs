using System;
using System.Collections.Generic;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    //Todo
    public class LT1654_MinJumpsToReachHome
    {
        HashSet<int> forbiddenSet = new HashSet<int>();

        public int MinimumJumps(int[] forbidden, int a, int b, int x)
        {
            foreach (var item in forbidden)
                forbiddenSet.Add(item);

            return Recurse(0, a, b, x, false, 0);
        }

        private int Recurse(int start, int a, int b, int x, bool isJumpBackWard, int jumps)
        {
            if (start < 0 || start > 60000 || forbiddenSet.Contains(start))
                return int.MaxValue;

            if (start == x)
                return 0;

            jumps++;
            int jumpsForward = Recurse(start + a, a, b, x, false, jumps);

            if (!isJumpBackWard)
            {
                jumps++;
                int jumpsBackward = Recurse(start - b, a, b, x, true, jumps);
            }

            return Math.Min(jumps, 0);
        }
    }
}
