using Bosscoder.Models;

namespace Bosscoder.Week1.Warmup_Assignments
{
    [TimeN]
    public sealed class MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            int rank = mat.Length;
            int j = 0;
            int i = 0;

            while(i < rank && j < rank)
            { 
                if (i == j)
                {
                    sum += mat[i][j];                    
                }
                else if (i + j == rank - 1)
                {
                    sum += mat[i][j];
                }

                j++;

                if(j == rank)
                {
                    j = 0;
                    i++;
                }
            }           

            return sum;
        }
    }
}
