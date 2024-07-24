using System;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT72_EditDistance
    {
        public int MinDistance(string word1, string word2)
        {
            return Memoize(word1, word2);
        }

        private int Memoize(string word1, string word2)
        {
            int s1 = word1.Length;
            int s2 = word2.Length;

            int[,] dp = new int[s1 + 1, s2 + 11];

            for (int i = 0; i <= s1; i++)
            {
                dp[i, 0] = i;
            }

            for (int j = 0; j <= s2; j++)
            {
                dp[0, j] = j;
            }

            for (int i = 1; i <= s1; ++i)
            {
                for (int j = 1; j <= s2; ++j)
                {
                    if (word1[i - 1] == word2[j - 1])//same characters
                        dp[i, j] = dp[i - 1, j - 1];//no operation
                    else
                        dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                }
            }

            return dp[s1,s2];
        }
    }
}