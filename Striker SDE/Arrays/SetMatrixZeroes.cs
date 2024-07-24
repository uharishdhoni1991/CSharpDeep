using System.Collections.Generic;

namespace Striker_SDE.Arrays
{
    public class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            int rowPointer = 0;
            int colPointer = 0;

            while (rowPointer < rowCount)
            {
                if (matrix[rowPointer][colPointer] == 0)
                {
                    rows.Add(rowPointer);
                    cols.Add(colPointer);
                }

                colPointer++;

                if (colPointer == colCount)
                {
                    colPointer = 0;
                    rowPointer++;
                }
            }

            rowPointer = 0;
            colPointer = 0;

            while (rowPointer < rowCount)
            {
                if(rows.Contains(rowPointer) || cols.Contains(colPointer))
                {
                    matrix[rowPointer][colPointer] = 0;
                }

                colPointer++;

                if(colPointer == colCount)
                {
                    colPointer = 0;
                    rowPointer++;
                }
            }
        }
    }
}
