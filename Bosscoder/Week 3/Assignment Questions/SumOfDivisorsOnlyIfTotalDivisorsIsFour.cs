using System;

namespace Bosscoder.Week_3.Assignment_Questions
{
    public class SumOfDivisorsOnlyIfTotalDivisorsIsFour
    {
        public int SumOFDivisorsOfCountFour(int[] arr)
        {
            //Check for 1-10
            int maxCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                int limit = (int)Math.Sqrt(n);
                int currCount = 0;
                int divCount = 0;

                for (int j = 1; j <= limit; j++)
                {
                    if (n % j == 0)
                    {
                        divCount++;
                        currCount += j;

                        if (n / j != j)
                        {
                            divCount++;
                            currCount += n / j;
                        }

                        if (divCount > 4)
                            break;
                    }
                }

                if (divCount == 4)
                {
                    maxCount += currCount;
                }
            }

            return maxCount;
        }
    }
}
