using System;

namespace TechGig.Practice
{
    internal class MatrixAddition : MatrixBase, IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Matrix Addition");

            string rowColumns = Console.ReadLine();
            int rows = 0;
            int cols = 0;
            string[] rowCol = rowColumns.Split(new string[] { " " }, StringSplitOptions.None);
            rows = Convert.ToInt32(rowCol[0]);
            cols = Convert.ToInt32(rowCol[1]);

            int[,] matrixA = GenerateMatrix(rows, cols);

            rowColumns = Console.ReadLine();            
            rowCol = rowColumns.Split(new string[] { " " }, StringSplitOptions.None);
            rows = Convert.ToInt32(rowCol[0]);
            cols = Convert.ToInt32(rowCol[1]);

            int[,] matrixB = GenerateMatrix(rows, cols);

            int[,] matrixC = AddMatrices(matrixA, matrixB, rows, cols);
            PrintMatrix(matrixC, rows, cols);
            Console.ReadLine();
        }        
    }
}