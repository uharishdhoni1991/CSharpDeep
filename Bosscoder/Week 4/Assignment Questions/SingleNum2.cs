namespace Bosscoder.Week_4.Assignment_Questions
{
    public class SingleNum2
    {
        /*Dry Run and Check*/
        public int Find(int[] num)
        {
            int ans = 0;
            for (int i = 0; i < 32; i++)
            {
                int sum = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    if (((num[j] >> i) & 1) == 1)
                    {
                        sum++;
                        sum %= 3;
                    }
                }
                if (sum != 0)
                {
                    ans |= sum << i;
                }
            }
            return ans;

        }
    }
}
