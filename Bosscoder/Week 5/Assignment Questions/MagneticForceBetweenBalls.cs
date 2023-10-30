using System;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Approach
     * 1)  Sort the Array
     * 2) start binary search, check if the difference between two value and target is > mid
     * 3) Perform binary search
    */

    /*Revise and Revisit*/
    public class MagneticForceBetweenBalls
    {
        public int MinMagneticForceBetweenBalls(int[] arr, int m)
        {
            Array.Sort(arr);
            int low = 1, high = arr[arr.Length - 1], ans = 0;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (IsPossible(arr, m, mid))
                {
                    low = mid + 1;
                    ans = mid;
                }
                else
                    high = mid - 1;
            }
            return ans;
        }
        bool IsPossible(int[] position, int m, int gap)
        {
            int prev = position[0];
            int places = 1;
            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] - prev >= gap)
                {
                    prev = position[i];
                    places++;
                    if (places >= m)
                        return true;
                }
            }
            return false;

        }
    }
}
