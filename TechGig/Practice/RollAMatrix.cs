using System;

namespace TechGig.Practice
{
    internal class RollAMatrix : MatrixBase, IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Roll Matrix");
            string rowColumns = Console.ReadLine();
            int rows = 0;
            int cols = 0;
            string[] rowCol = rowColumns.Split(new string[] { " " }, StringSplitOptions.None);
            rows = Convert.ToInt32(rowCol[0]);
            cols = Convert.ToInt32(rowCol[1]);

            int[,] matrixA = GenerateMatrix(rows, cols);

            RollMatrix(matrixA, rows, cols);
            PrintMatrix(matrixA, rows, cols);
            Console.ReadLine();
        }
       
    }
}