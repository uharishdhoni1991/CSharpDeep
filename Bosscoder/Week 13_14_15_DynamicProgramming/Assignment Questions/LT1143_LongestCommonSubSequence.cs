using System;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT1143_LongestCommonSubSequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int n1 = text1.Length, n2 = text2.Length;
            int[,] dp = new int[n1 + 1, n2 + 1];
            for (int j = 1; j <= n2; j++)
            {
                for (int i = 1; i <= n1; i++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[n1, n2];
        }
    }
}
