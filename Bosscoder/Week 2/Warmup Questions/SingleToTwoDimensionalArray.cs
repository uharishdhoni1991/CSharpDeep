namespace Bosscoder.Week_2.Warmup_Questions
{
    public class SingleToTwoDimensionalArray
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {

            if (original.Length != m * n)
                return new int[][] { };

            int[][] resultantArray = new int[m][];
            int arrayIteration = 0;

            for (int i = 0; i < m; i++)
            {
                resultantArray[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    resultantArray[i][j] = original[arrayIteration];
                    arrayIteration++;
                }
            }

            return resultantArray;
        }
    }
}
