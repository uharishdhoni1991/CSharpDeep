using System.Collections.Generic;

namespace LeetCodeV2.Daily_Problems
{
    public class CountingNoOfOnes
    {
        /*ToDo* : Count no of ones in a binary representation of numbers from one to N and return them in a array*/
        public int[] CountNoOfOnes(int n)
        {
            List<int> oneCounts = new List<int>();
            int i = 0;

            while(i < n)
            {
                oneCounts.Add(CountOnes(i));
                i++;
            }

            return oneCounts.ToArray();
        }

        private int CountOnes(int i)
        {
            int count = 0;

            while (i >0)
            {
                //bitwise and
                count += i & 1;
                //Right shift by 1 bit
                i >>= 1;
            }

            return count;
        }
    }
}
