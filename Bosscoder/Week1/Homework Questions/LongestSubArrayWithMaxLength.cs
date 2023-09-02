namespace Bosscoder.Week1.Homework_Questions
{
    public class LongestSubArrayWithMaxLength
    {
        public int LongestSubArray(int[] input)
        {
            int maxLengthFound = 0, maxSumFound = 0, iterationMaxLength = 0, iterationSumFound = 0;

            for(int i =0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    iterationSumFound = iterationSumFound + input[i];
                    ++iterationMaxLength;
                }
                else
                {
                    if (iterationMaxLength > maxLengthFound || (iterationMaxLength == maxLengthFound && iterationSumFound >= maxSumFound))
                    {
                        maxSumFound = iterationSumFound;
                        maxLengthFound = iterationMaxLength;
                    }                   

                    iterationMaxLength = 0;
                    iterationSumFound = 0;
                }                
            }

            if (iterationMaxLength > maxLengthFound || (iterationMaxLength == maxLengthFound && iterationSumFound >= maxSumFound))
                return iterationMaxLength;
            else
                return maxLengthFound;
        }
    }
}
