namespace Bosscoder.Week_4.Assignment_Questions
{
    public class NumberOf1Bits
    {
        public int Solve(string s)
        {
            int oneCount = 0;

            foreach(char c in s)
            {
                if ((c & 1) == 1)
                    oneCount += 1;
            }

            return oneCount;
        }
    }
}
