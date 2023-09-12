using System;

namespace Bosscoder.Week_2.Warmup_Questions
{
    public class SpecialPositionsInMatrix
    {
        public int NumSpecial(int[][] matrix)
        {
            int count = 0;

            for(int i =0; i < matrix.Length; i++)
            {
                for(int j=0; j < matrix[i].Length; j++)
                {
                    count += IsNumSpecial(matrix, i , j) ? 1 : 0;
                }
            }

            return count;
        }

        private bool IsNumSpecial(int[][] matrix, int row, int column)
        {
            if (matrix[row][column] != 1)
                return false;

            for(int i=0; i < matrix[row].Length; i++)
            {
                if (i == column)
                    continue;

                if (matrix[row][i] == 1)       
                    return false;                    
            }

            for(int i=0;  i < matrix.Length; i++)
            {
                if (i == row)
                    continue;

                if (matrix[i][column] == 1)
                    return false;
            }

            return true;
        }
    }
}
