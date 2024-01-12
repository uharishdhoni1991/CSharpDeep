using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosscoder.Mentorship
{
    // Array of length n - Stock prices 
    // Constraint - buy & sell one time to get max profit !

    // Follow up Questions
    // Allowed to have atmost two transactions
    // Atmost k trans
    // Unlimited

    //Binary tree
    // Node contains -ve & +ve numbers , return maxSum from tree (Entire tree)
    // Divide into cases - 

    //https://www.interviewbit.com/problems/gas-station/

    //ToDo
    public class Array
    {
        public int Solve()
        {
            int[] arr = new int[] { 6, 5, 11, 12, 17, 3, 10};

            // Day 1 - 1 unit - 6- Buy
            // Day 2 - 1 unit - 5 - Buy 
            // Day 3 - 11 - Sell / Buy
            // Day 4 - ...

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int maxProfit = 0;

            foreach(var item in arr)
            {
                minValue = item < minValue ? item : minValue;
                maxValue = maxValue > item ? maxValue : item;

                maxProfit = Math.Max(maxProfit, maxValue - minValue);
            }

            return maxProfit;
        }
    }
}
