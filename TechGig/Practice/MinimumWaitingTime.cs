using System;
using System.Linq;

namespace TechGig.Practice
{
    public class MinimumWaitingTime : IExecute
    {
        public void Execute()
        {
            int[] input = new int[] { 3, 2, 1, 2, 6 };
            int mwt = GetMinimumWaitingTime(input);
        }

        [TimeN]
        public int GetMinimumWaitingTime(int[] input)
        {
            /*Hint 
            (n - 1)i + (n - 2)(i + 1) + (n - 3)(i + 2) + (n - 4)(i + 3)*/

            int mwt = 0;
            int multiplier = input.Length - 1;

            Array.Sort(input);

            for (int i = 0; i < input.Length - 1; i++)
            {
                mwt += (input[i] * multiplier);
                --multiplier;
            }

            return mwt;
        }
    }
}
