namespace Bosscoder.Week_3.Assignment_Questions
{
    public class CheckIfPairsDivisibleByK
    {
        /*Divisors occur in pairs , i and k-i*/
        /*Revisit and Revise*/
        public bool CanArrange(int[] arr, int k)
        {
            int[] frequency = new int[k];
            int number = 0;
            foreach (int num in arr)
            {
                number = num % k;
                if (number < 0) number += k;
                frequency[number]++;
            }
            if (frequency[0] % 2 != 0) return false;

            for (int i = 1; i <= k / 2; i++)
                if (frequency[i] != frequency[k - i]) return false;

            return true;
        }
    }
}
