using System.Collections.Generic;

namespace Bosscoder.Week_6.Homework_Questions
{
    public class SetMatrixZeroesHashing
    {
        public int[][] Solve(int[][] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            int rowCount = matrix[0].Length;
            int columnCount = matrix.Length;

            int rowPointer = 0;
            int columnPointer = 0;

            while (rowPointer < rowCount)
            {
                if (matrix[rowPointer][columnPointer] == 0)
                {
                    rows.Add(rowPointer);
                    cols.Add(columnPointer);
                }

                columnPointer++;

                if (columnPointer == columnCount)
                {
                    columnPointer = 0;
                    rowPointer++;
                }
            }

            rowPointer = 0;
            columnPointer = 0;

            while (rowPointer < rowCount)
            {
                if (rows.Contains(rowPointer) || cols.Contains(columnPointer))
                    matrix[rowPointer][columnPointer] = 0;                

                columnPointer++;

                if (columnPointer == columnCount)
                {
                    columnPointer = 0;
                    rowPointer++;
                }
            }

            return matrix;
        }
    }
}