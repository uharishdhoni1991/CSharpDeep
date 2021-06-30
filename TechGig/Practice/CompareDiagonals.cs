using System;

namespace TechGig.Practice
{
    internal class CompareDiagonals : MatrixBase, IExecute
    {
        /*
         0,0 0,1 0,2
         1,0 1,1 1,2
         2,0 2,1 2,2
         
         Diagonal1 = (r,c)
         Diagonal2 = (r=n-r-1,c=r)*/

        public void Execute()
        {
            Console.WriteLine("Matrix Diagonal Comparison");

            string rowColumns = Console.ReadLine();
            int rows = 0;
            int cols = 0;
            string[] rowCol = rowColumns.Split(new string[] { " " }, StringSplitOptions.None);
            rows = Convert.ToInt32(rowCol[0]);
            cols = Convert.ToInt32(rowCol[1]);

            int[,] matrixA = GenerateMatrix(rows, cols);

            (int,int) diagonals = CompareDiagonals(matrixA, rows, cols);

            if (diagonals.Item1 > diagonals.Item2)
                Console.WriteLine("Diagonal 1");
            else if (diagonals.Item1 == diagonals.Item2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Diagonal 2");
        }
    }
}