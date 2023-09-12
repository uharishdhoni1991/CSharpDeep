using Bosscoder.Models;

namespace Bosscoder.Week_2.Assignment_Questions
{   
    public class SearchTwoDimensionalMatrix
    {
        [TimeLimitExceeded]
        public bool SearchInMatrix(int[][] matrix, int num)
        {
            int left = 0, right = matrix[0].Length-1, top = left+1, bottom= matrix.Length -1;
            int i = 0, j = 0;

            while(true)
            {              
                if (left <= right)
                {
                    if (matrix[i][left] == num)
                        return true;
                    else if (matrix[i][right] == num)
                        return true;

                    left++;
                    right--;

                    if(left > right)                
                        i++;                    
                }

                if (top <= bottom)
                {
                    if (matrix[top][j] == num)
                        return true;
                    else if (matrix[bottom][j] == num)
                        return true;

                    top++;
                    bottom--;

                    if (top > bottom)
                        j++;

                    if (j == matrix.Length)
                        break;
                }

                if (left > right && top > bottom)
                {
                    left = i;
                    right = matrix[j].Length - 1;
                    top = left + 1;
                }
            }

            return false;
        }

        public bool SearchInMatrixOptimised(int[][] matrix, int num)
        {
            int row = 0, column = matrix[0].Length - 1;

            while(column >= 0 && row < matrix.Length)
            {
                if (matrix[row][column] == num)
                    return true;
                else if (matrix[row][column] > num)
                    column--;
                else if (matrix[row][column] < num)
                    row++;
            }

            return false;
        }
    }
}
