using System;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Revise and Revisit*/
    public class CapacityToShipPackages
    {
        public int Solve(int[] input, int days)
        {
            int ans = int.MaxValue;
            int low = 1, high =int.MaxValue;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int count = 0, sum = 0;
                bool flag = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > mid)
                    {
                        flag = false;
                    }
                    if (sum + input[i] <= mid)
                    {
                        sum += input[i];
                    }
                    else
                    {
                        count++;
                        sum = input[i];
                    }
                }

                if (count + 1 <= days && flag){
                    ans = Math.Min(ans, mid);
                    high = mid - 1;
                }else
                {
                    low = mid + 1;
                }

            }
            return ans;
        }
    }
}
