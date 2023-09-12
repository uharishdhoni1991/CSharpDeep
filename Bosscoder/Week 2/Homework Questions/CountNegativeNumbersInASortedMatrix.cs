namespace Bosscoder.Week_2.Homework_Questions
{
    public class CountNegativeNumbersInASortedMatrix
    {
        /*Matrix is sorted by descending*/
        public int FindNegativeElementCount(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return 0;

            int colLength = matrix[0].Length - 1;
            int row = 0, col = colLength, count = 0;

            while(row <= matrix.Length - 1 && col >= 0)
            {
                if (matrix[row][col] < 0)
                {
                    count++;
                    col--;

                    if (col < 0)
                    {
                        row++;
                        col = colLength;
                    }                    
                }
                else
                {
                    row++;
                    col = colLength;
                }               
            }
            return count;
        }
    }
}
