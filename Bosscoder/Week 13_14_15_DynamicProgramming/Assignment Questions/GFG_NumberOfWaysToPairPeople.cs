using System;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class GFG_NumberOfWaysToPairPeople
    {
        public int Solve(int p)
        {
            /*Arriving at a formula 
             From a total of P people either individual or pair dance is possible
             f(p) = f(single) + f(pair)
             f(single) = f(p-1) , since only p-1 people are remaining
             f(pair) = (p-1) [Since one person is selected from p] multipied by the function to select next one f(p-2
             f(p) = f(p-1) + (p-1) * f(p-2)*/
            
            return Tabulate(p);
        }

        [Memoization]
        private int Tabulate(int p)
        {
            if (p <= 0)
                return 0;

            if (p == 1)
                return 1;

            int[] dp = new int[p + 1];
            dp[1] = 1;
            dp[2] = 2;


            for(int i = 3; i <= p; i++)
            {
                dp[i] = dp[i - 1] + ((i - 1) * dp[i - 2]);
            }

            return dp[p];
        }
    }
}
