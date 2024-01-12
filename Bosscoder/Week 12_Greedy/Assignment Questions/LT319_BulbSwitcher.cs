using Bosscoder.Models;
using System;
using System.Linq;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class LT319_BulbSwitcher
    {
        [TimeLimitExceeded]
        public int BulbSwitch(int n)
        {
            if (n == 0)
                return 0;

            bool[] res = new bool[n+1];

            for(int i =1; i <= n; i++)
            {
                for(int j = i; j <= n; j++)
                {
                    if (j % i == 0)
                        res[j] = Toggle(res[j]);
                }
            }

            return res.Count(x => x);
        }

        [Time1]
        public int Solve(int n)
        {
            return (int)Math.Sqrt(n);
        }

        private bool Toggle(bool toggle)
        {
            if (toggle)
                return false;

            return true;
        }
    }
}