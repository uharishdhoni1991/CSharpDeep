using System;

namespace LeetCodeV2.Daily_Problems
{
    public class ReducingDishes
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            int res = 0;
            int total = 0;
            Array.Sort(satisfaction);

            for (int i = satisfaction.Length-1; i >0 && satisfaction[i] > -total; --i)
            {
                total += satisfaction[i];
                res += total;
            }

            return res;
        }
    }
}
