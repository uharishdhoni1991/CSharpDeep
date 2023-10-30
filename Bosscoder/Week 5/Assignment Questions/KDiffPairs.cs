using System;
using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Copy paste, dry run and check pls, revisit and revise*/
    public class KDiffPairs
    {
        private int BinarySearch(int[] arr, int low, int high,int x)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                if (x == arr[mid])
                    return mid;
                if (x > arr[mid])
                    return BinarySearch(arr, (mid + 1), high,
                                        x);
                else
                    return BinarySearch(arr, low, (mid - 1), x);
            }

            return -1;
        }

        // Returns count of pairs with
        // difference k in arr[] of size n.
        public int CountPairsWithDiffK(int[] arr, int n, int k)
        {
            int count = 0, i;

            // Sort array elements
            Array.Sort(arr);

            // code to remove duplicates from arr[]

            // Pick a first element point
            for (i = 0; i < n; i++)
            {
                while (i - 1 >= 0 && arr[i] == arr[i - 1])
                    i++;

                if (BinarySearch(arr, i + 1, n - 1, arr[i] + k)
                    != -1)
                    count++;
            }

            return count;
        }
    }
}
