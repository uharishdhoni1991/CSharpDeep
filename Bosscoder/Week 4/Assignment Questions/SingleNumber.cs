namespace Bosscoder.Week_4.Assignment_Questions
{
    public class SingleNumber
    {
        public int FindSingleNumber(int[] n)
        {
            int exp = 0;

            foreach(int num in n)
            {
                exp = exp ^ num;
            }

            return exp;
        }
    }
}
