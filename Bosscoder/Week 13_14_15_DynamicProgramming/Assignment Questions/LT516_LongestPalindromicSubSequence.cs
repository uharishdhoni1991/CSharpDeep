using Bosscoder.Models;
using System;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT516_LongestPalindromicSubSequence
    {
        public int Solve(string s)
        {
            //Highest possibility is that the entire string can be palindrome so start from there
            int[,] cache = new int[s.Length,s.Length];           

            return Helper(s, 0, s.Length - 1, cache);
        }

        public int SolveTabulation(string s)
        {
            return Helper(s);
        }

        [TimeLimitExceeded]
        private int Helper(string s, int left, int right, int[,] cache)
        {
            if (left == right)
                return 1;

            if (left > right)
                return 0;

            if(s[left] == s[right])
            {
                cache[left, right] = 2 + Helper(s, left + 1, right - 1, cache);
                return cache[left, right];
            }

            int leftIncrement = Helper(s, left+1, right, cache);
            int rightIncrement = Helper(s, left, right-1, cache);
            int max = Math.Max(leftIncrement, rightIncrement);

            cache[left, right] = max;

            return cache[left, right];
        }

        [Tabulation]
        public int Helper(string s)
        {
            int[,] dp = new int[s.Length + 1, s.Length + 1];

            for (int i = 0; i < s.Length; i++)
            {
                dp[i,i] = 1;
            }

            for (int i = s.Length - 2; i >= 0; i--)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                     if (s[i] == s[j])
                        dp[i, j] = 2 + dp[i + 1, j - 1];
                    else
                        dp[i, j] = Math.Max(dp[i, j-1], dp[i+1, j]);
                }
            }

            return dp[0, s.Length-1];
        }
    }
}
