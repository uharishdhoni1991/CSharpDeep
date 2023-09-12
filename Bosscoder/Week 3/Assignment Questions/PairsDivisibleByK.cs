using System.Collections.Generic;

namespace Bosscoder.Week_3.Assignment_Questions
{
    public class PairsDivisibleByK
    {
        /* arr[] = 0 , 1, 2, 3, 4, 5
           divide by 5 which is k
           store results accordingly*/

        public int NoOfPairsDivisibleByK(int[] arr, int k)
        {
            Dictionary<int, int> divisibleByK = new Dictionary<int, int>(); 

            for(int i = 0; i < arr.Length; i++)
            {
                int remainder = arr[i] % k;

                if (divisibleByK.ContainsKey(remainder))
                {
                    divisibleByK[remainder]++;
                }
                else
                {
                    divisibleByK.Add(remainder, 0);
                }
            }

            return 0;

        }
    }
}

