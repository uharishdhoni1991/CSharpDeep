using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT120_TriangleArray
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
           List<IList<int>> dp = new List<IList<int>>();
            
            dp.Add(new List<int> { triangle[0][0] });

            for(int i = 1; i < triangle.Count; i++)
            {
                dp.Add(new List<int>());
                int sum = 0;

                for (int j = 0; j < triangle[i].Count; j++)
                {
                    if (j == 0)
                        sum = dp[i - 1][j] + triangle[i][j];
                    else
                    {
                        if (j == triangle[i].Count - 1)
                            sum = dp[i - 1][j - 1] + triangle[i][j];
                        else
                            sum = Math.Min(dp[i - 1][j - 1], dp[i - 1][j]) + triangle[i][j];
                    }

                   dp[i].Add(sum);                   
                }                       
            }

            return dp[triangle.Count-1].Min(y => y);
        }
    }
}