namespace Bosscoder.Week_4.Assignment_Questions
{
    public class ReverseBits
    {
        /*Revisit tomorrow and revise*/
        public int GetReversedInteger(string input)
        {
            int res = 0;

            for (int i = 31; i >= 0; i--)
            {
                res <<= 1;
                res += (input[i] - '0') % 2;
            }

            return res;
        }
    }
}
