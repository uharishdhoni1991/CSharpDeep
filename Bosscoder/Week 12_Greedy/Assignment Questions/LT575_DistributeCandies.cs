using System;
using System.Collections.Generic;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class LT575_DistributeCandies
    {
        public int DistributeCandies(int[] candyType)
        {
            HashSet<int> set = new HashSet<int>();
            
            foreach (int type in candyType)
            {
                set.Add(type);
            }

            return Math.Min(set.Count, candyType.Length / 2);
        }
    }
}