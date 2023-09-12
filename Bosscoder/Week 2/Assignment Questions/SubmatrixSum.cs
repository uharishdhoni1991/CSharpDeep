namespace Bosscoder.Week_2.Assignment_Questions
{
    public class SubmatrixSum
    {
        //ToDo : Need to revisit  and revise this logic
        public int FindSumOfAllSubMatrices(int[][] arr)
        {
            int sum = 0;

            // Nested loop to find the number of 
            // submatrices, each number belongs to
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                    // Number of ways to choose
                    // from top-left elements
                    int top_left = (i + 1) * (j + 1);

                    // Number of ways to choose
                    // from bottom-right elements
                    int bottom_right = (arr.Length - i) * (arr.Length - j);
                    sum += (top_left * bottom_right * arr[i][j]);
                }
            }

            return sum;
        }
    }
}
