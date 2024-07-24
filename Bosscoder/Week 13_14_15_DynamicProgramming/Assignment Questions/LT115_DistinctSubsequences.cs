using Bosscoder.Models;
using System;
using System.Linq;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT115_DistinctSubsequences
    {
        private string _parent;
        private string _child;
        
        public int NumDistinct(string s, string t)
        {

            _parent = s;
            _child = t;
            
            return FindDistinct(0, 0);
        }

        public int NumDistinctMemoized(string s, string t)
        {

            _parent = s;
            _child = t;

            int[,] dp = new int[s.Length + 1, t.Length + 1];

            for (int i = 0; i < s.Length; i++)                
            {
                for (int j = 0; j < t.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return FindDistinct(0, 0, dp);
        }

        [Memoization]
        private int FindDistinct(int parentIndex, int childIndex, int[,] dp)
        {
            if (childIndex == _child.Length)
                return 1;

            if (parentIndex == _parent.Length)
                return 0;

            if (dp[parentIndex, childIndex] != -1)
                return dp[parentIndex, childIndex];

            int take = 0, notTake = 0;

            if (_parent[parentIndex] == _child[childIndex])
            {
                take = FindDistinct(parentIndex + 1, childIndex + 1, dp);
            }

            notTake = FindDistinct(parentIndex + 1, childIndex, dp);

            dp[parentIndex, childIndex] = take + notTake;
            return dp[parentIndex, childIndex];
        }

        [TimeLimitExceeded]
        [Recursion]
        private int FindDistinct(int parentIndex, int childIndex)
        {
            if (childIndex == _child.Length)
                return 1;

            if (parentIndex == _parent.Length)
                return 0;

            int take = 0, notTake = 0;

            if (_parent[parentIndex] == _child[childIndex])
            {                
                take =FindDistinct(parentIndex + 1, childIndex + 1);
            }

            notTake = FindDistinct(parentIndex + 1, childIndex);

            return take + notTake;
        }
    }
}
