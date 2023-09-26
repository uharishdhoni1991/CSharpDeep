using System;

namespace Bosscoder.Week_4.Homework_Questions
{
    /* Approach
     * For any given 'K', our answer will be 5 or 0.

        5 -> When it's possible to achieve 'K' zeros
        0 -> When there isn't any number whose factorial will have 'K' Zeros

        0 to 4 -> 0 zeros
        5 to 9 -> 1 zeros
        10 to14 -> 2 zeros
        15 to 19 -> 3 zeros
        20 to 24 -> 4 zeros

        No Range available for 5 zeros.

        25 to 29 -> 6 zeros
        30 to 34-> 7 zeros
        35 to 39 -> 8 zeros
        40 to 44 -> 9 zeros
        45 to 49 -> 10 zeros

        No Range available for 11 zeros.

        50 to 55 -> 12 zeros

        As you can see there are either 5 values for avery 'K' or none. 
        Therefore we will simply use binary search to check if it's possible 
        to achive 'K' Zeros we return 5 and if it's not we return Zero. */
    /*Revise and Revisit*/
    public class PreImageSize
    {
        public int PreImageSizeFZF(int k)
        {
            long low = 0;
            long high = (long)Math.Pow(10, 10);
            

            while(low <= high)
            {
                long midValue = low + (high - low) / 2;
                long value = midValue;
                long ans = 0;

                while (value != 0)
                {
                    value = value / 5;
                    ans += value;
                }

                if (ans == k)
                    return 5;
                else if (ans > k)
                    high = midValue - 1;
                else
                    low = midValue + 1;
            }

            return 0;
        }     
    }
}
