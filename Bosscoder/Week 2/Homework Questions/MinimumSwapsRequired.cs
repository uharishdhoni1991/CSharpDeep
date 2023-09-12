using System;

namespace Bosscoder.Week_2.Homework_Questions
{
    public class MinimumSwapsRequired
    {
        public int MinSwap(int[] arr, int n, int k)
        {
            //Sliding window technique
            /* - Find the initial window - no of matching numbers
             * - Find the number of swaps required - no of non matching numbers within 
             * the initial window got.
             * - Find the minvalue between Int32.Max and Numbr of swaps and store in ans_swaps
              - Iterate from windowend till end of array Checking in every window no. of swap 
            * required and storing its minimum
            */

            /*ToDo: Revisit and Revise*/
            int snowBallSize = 0;

            for (int i = 0; i < n; i++)
            {

                // Calculating the size of window required
                if (arr[i] <= k)
                {
                    snowBallSize++;
                }
            }

            int swap = 0, ans_swaps = Int32.MaxValue;

            for (int i = 0; i < snowBallSize; i++)
            {
                if (arr[i] > k)
                    swap++;
            }

            ans_swaps = Math.Min(ans_swaps, swap);

            for (int i = snowBallSize; i < n; i++)
            {

                // Checking in every window no. of swaps
                // required and storing its minimum
                if (arr[i - snowBallSize] <= k && arr[i] > k)
                    swap++;
                else if (arr[i - snowBallSize] > k
                         && arr[i] <= k)
                    swap--;
                ans_swaps = Math.Min(ans_swaps, swap);
            }

            return ans_swaps;
        }
    }
}