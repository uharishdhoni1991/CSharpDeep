namespace Bosscoder.Week_2.Assignment_Questions
{
    public class MaxChunksToSorted
    {
        int maxChunkCount = 0;
        int currentSum = 0;
        int expectedSum = 0;

        public int FindMaxChunks(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                expectedSum += i;
                currentSum += arr[i];

                if (currentSum == expectedSum)
                    maxChunkCount++;
            }

            return maxChunkCount;
        }
    }
}
