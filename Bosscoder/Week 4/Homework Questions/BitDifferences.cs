namespace Bosscoder.Week_4.Homework_Questions
{
    public class BitDifferences
    {
        /*An Efficient Solution can solve this problem in O(n) time using the fact that all numbers 
         * are represented using 32 bits(or some fixed number of bits). The idea is to count 
         * differences at individual bit positions.We traverse from 0 to 31 and count numbers 
         * with i’th bit set.Let this count be ‘count’. There would be “n-count” numbers 
         * with i’th bit not set. So count of differences at i’th bit would be “count* (n-count) * 2”, 
         * the reason for this formula is as every pair having one element which has set bit
         * at i’th position and second element having unset bit at i’th position contributes exactly 1 to sum,
         * therefore total permutation count will be count*(n - count) and multiply by 2 is due to one more
         * repetition of all this type of pair as per given condition for making pair 1 <= i, j <= N.
         */

        /* Revisit and Revise*/
        public int GetSumOfBitDifferences(int[] arr)
        {
            int n = arr.Length;
            int ans = 0; // Initialize result

            // traverse over all bits
            for (int i = 0; i < 32; i++)
            {

                // count number of elements
                // with i'th bit set
                int count = 0;
                for (int j = 0; j < n; j++)
                    if ((arr[j] & (1 << i)) != 0)
                        count++;

                // Add "count * (n - count) * 2"
                // to the answer
                ans += (count * (n - count) * 2);
            }

            return ans;
        }
    }
}
