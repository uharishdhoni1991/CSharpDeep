using System.Collections.Generic;

namespace Bosscoder.Week1.Homework_Questions
{
    public class SetMatrixZeroes
    {
        public int[][] SetZeroes(int[][] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix[0].Length;

            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            int rowPointer = 0;
            int columnPointer = 0;

            while(rowPointer < rowCount)
            {
                if(matrix[rowPointer][columnPointer] == 0)
                {
                    rows.Add(rowPointer);
                    cols.Add(columnPointer);
                }

                columnPointer++;

                if(columnPointer == columnCount)
                {
                    columnPointer = 0;
                    rowPointer++;
                }
            }

            rowPointer = 0;
            columnPointer = 0;

            while(rowPointer < rowCount)
            {
                if (rows.Contains(rowPointer) || cols.Contains(columnPointer))
                    matrix[rowPointer][columnPointer] = 0;

                columnPointer++;

                if(columnPointer == columnCount)
                {
                    columnPointer = 0;
                    rowPointer++;
                }
            }

            return matrix;
        }
    }
}
