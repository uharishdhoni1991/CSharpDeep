namespace Bosscoder.Week_3.Warmup_Questions
{
    public class SubstractProductAndSum
    {
        public int GetDifferenceOfProductAndSum(int n)
        {
            int sum = 0;
            int prod = 1;

            while (n != 0)
            {
                int remain = n % 10;
                n = n / 10;

                sum += remain;
                prod *= remain;
            }

            return prod - sum;
        }
    }
}
