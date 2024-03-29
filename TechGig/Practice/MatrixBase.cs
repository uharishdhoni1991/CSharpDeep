﻿using System;

namespace TechGig.Practice
{
    internal class MatrixBase
    {
        protected void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);

                    if (col != cols - 1)
                        Console.Write(' ');
                }

                Console.WriteLine();
            }
        }

        protected int[,] AddMatrices(int[,] matrixA, int[,] matrixB, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixA[row, col] + matrixB[row, col];
                }
            }

            return matrix;
        }

        protected int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string elementLine = Console.ReadLine();
                string[] elements = elementLine.Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Convert.ToInt32(elements[col]);
                }
            }

            return matrix;
        }

        protected (int,int) CompareDiagonals(int[,] matrix, int rows, int cols)
        {
            int[] diagonal1 = new int[rows];
            int[] diagonal2 = new int[cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col)
                        diagonal1[row] = matrix[row, col];
                }
            }

            int diagRow2 = rows - 1;
            int diagCol2 = 0;
            while (diagRow2 >= 0 && diagCol2 <= cols)
            {
                diagonal2[diagCol2] = matrix[diagRow2, diagCol2];
                diagRow2--;
                diagCol2++;
            }
           
            int diagonal1Sum = 0;
            int diagonal2Sum = 0;
            for (int i = 0; i < rows; i++)
            {
                diagonal1Sum += diagonal1[i];
                diagonal2Sum += diagonal2[i];
            }

            return (diagonal1Sum, diagonal2Sum);
        }

        protected void RollMatrix(int[,] matrix, int rows, int cols)
        {
            bool[,] swapState = new bool[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (swapState[row, col] || swapState[col, row])
                        continue;

                    int temp = matrix[col, row];
                    matrix[col, row] = matrix[row, col];
                    matrix[row, col] = temp;

                    swapState[row, col] = swapState[col, row] = true;
                }
            }
        }
    }
}