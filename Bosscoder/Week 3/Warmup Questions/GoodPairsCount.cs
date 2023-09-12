namespace Bosscoder.Week_3.Warmup_Questions
{
    public class GoodPairsCount
    {
        public int GetGoodPairsCount(int[] arr)
        {
            int goodPairsCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        goodPairsCount++;
                }
            }

            return goodPairsCount;
        }
    }
}
