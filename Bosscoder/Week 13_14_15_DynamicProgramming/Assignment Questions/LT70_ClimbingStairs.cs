using System.Linq;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT70_ClimbingStairs
    {    
        [Memoization]
        public int Memoize(int n, int[] dp)
        {
            if (n <= 1)
                return 1;

            if(dp[n] != -1)
                return dp[n];

            dp[n] = Memoize(n - 1, dp) + Memoize(n - 2, dp);

            return dp[n];
        }

        [Tabulation]
        public int Tabulate(int n)
        {
            if (n <= 1)
                return 1;

            int[] tab = Enumerable.Repeat<int>(0, n + 1).ToArray();

            tab[0] = 1;
            tab[1] = 1;

            for(int i = 2; i <= n; i++)
            {
                tab[i] = tab[i - 1] + tab[i - 2];
            }

            return tab[n];
        }

        [SpaceOptimisation]
        public int SpaceOptimise(int n)
        {
            if (n <= 1)
                return n;

            int firstNum = 1;
            int secondNum = 1;

            int thirdNum = firstNum + secondNum;

            for (int i = 2; i < n; i++)
            {
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = firstNum + secondNum;
            }            

            return thirdNum;
        }
    }
}
