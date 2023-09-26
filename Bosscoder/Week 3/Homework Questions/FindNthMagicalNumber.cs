namespace Bosscoder.Week_3.Homework_Questions
{
    public class FindNthMagicalNumber
    {
        /* Each number that can be formed is either a power of 5 or sum of unique powers of 5
         * Approach here is that the numbers can be represented as binary series with each digit
         * correspondng to powers of 5 as 001 (5), 010 (25), 011 (30) etc
         * 
         */
        public int FIndNthMagicalNumberPow5(int n)
        {
            int ans = 0, pow = 1;

            while (n != 0)
            {
                pow = pow * 5;

                //Check if last bit is set and add to ans
                ans += ((int)n & 1) == 1 ? pow : 0;

                //right shift by one digit
                n >>= 1;
            }

            return ans;
        }
    }
}
