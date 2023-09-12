using Bosscoder.Week_2.Assignment_Questions;
using Bosscoder.Week_2.Homework_Questions;
using Bosscoder.Week_3.Assignment_Questions;
using Bosscoder.Week1.Assignment_Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bosscoder_Tests.Week1.Assignment_Questions
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void WaterTrappingTest()
        {
            WaterTrappingProblem wtt = new WaterTrappingProblem();

            int[] height = new int[] { 4, 2, 0, 3, 2, 5 };
            int expectedWaterTrapped = 9;

            int actualWaterTrapped = wtt.Trap(height);

            Assert.AreEqual(expectedWaterTrapped, actualWaterTrapped);
        }

        [TestMethod]
        public void MaxAbsValueExpTest()
        {
            MaxAbsValueExp maxAbs = new MaxAbsValueExp();

            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int[] arr2 = new int[] { -1, 4, 5, 6 };

            int expectedMax = 13;
            int actualMax = maxAbs.MaxAbsValExpr(arr1, arr2);

            Assert.AreEqual(expectedMax, actualMax);

            int[] arr3 = new int[] { 1, -2, -5, 0, 10 };
            int[] arr4 = new int[] { 0, -2, -1, -7, -4 };

            int expectedMax2 = 20;
            int actualMax2 = maxAbs.MaxAbsValExpr(arr3, arr4);

            Assert.AreEqual(expectedMax2, actualMax2);

            int[] arr5 = new int[] { 1, -2 };
            int[] arr6 = new int[] {8 , 8};

            int expectedMax3 = 4;
            int actualMax3 = maxAbs.MaxAbsValExpr(arr5, arr6);

            Assert.AreEqual(expectedMax3, actualMax3);
        }

        [TestMethod]
        public void GenerateSpiralMatrixTest()
        {
            SpiralMatrix spm = new SpiralMatrix();

            int[][] expectedMatrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 8, 9, 4 }, new int[] { 7, 6, 5 } };
            int[][] actualMatrix = spm.GenerateMatrix(3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(expectedMatrix[i][j] ,actualMatrix[i][j]);
                }
            }           
        }

        [TestMethod]
        public void CheckMaximumGap()
        {
            MaxGapProblem maxGap = new MaxGapProblem();

            int[] input = new int[] { 3, 6, 9, 1 };
            int expected = 3;

            int actual = maxGap.MaximumGap2(input);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SearchInTwoDArrayTest()
        {
            SearchTwoDimensionalMatrix stdm = new SearchTwoDimensionalMatrix();

            int[][] matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            bool expected = true;

            bool actual = stdm.SearchInMatrixOptimised(matrix, 9);
            Assert.AreEqual(expected, actual);

            int[][] matrix2 = new int[][] { new int[] { -5 } };
            bool expected2 = true;

            bool actual2 = stdm.SearchInMatrixOptimised(matrix2, -5);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void RangeSumTest()
        {           
            int[][] matrix = new int[][]
            {
                new int[] {3, 0, 1, 4, 2 },
                new int[] {5, 6, 3, 2, 1 },
                new int[] {1, 2, 0, 1, 5 },
                new int[] {4, 1, 0, 1, 7 },
                new int[] { 1, 0, 3, 0, 5 }
            };

            RangeSumInTwoDimensionalMatrix rsm = new RangeSumInTwoDimensionalMatrix(matrix);

            int expected = 8;            

            int actual = rsm.SumRegion(2, 1, 4, 3);
            Assert.AreEqual(expected, actual);

            int[][] matrix2 = new int[][]
            {
                new int[] {3, 0, 1, 4, 2 },
                new int[] {5, 6, 3, 2, 1 },
                new int[] {1, 2, 0, 1, 5 },
                new int[] {4, 1, 0, 1, 7 },
                new int[] { 1, 0, 3, 0, 5 }
            };

            rsm = new RangeSumInTwoDimensionalMatrix(matrix2);
            int expected1 = 11;

            int actual1 = rsm.SumRegion(1, 1, 2, 2);
            Assert.AreEqual(expected1, actual1);

            int[][] matrix3 = new int[][]
            {
                new int[] {3, 0, 1, 4, 2 },
                new int[] {5, 6, 3, 2, 1 },
                new int[] {1, 2, 0, 1, 5 },
                new int[] {4, 1, 0, 1, 7 },
                new int[] { 1, 0, 3, 0, 5 }
            };

            rsm = new RangeSumInTwoDimensionalMatrix(matrix3);
            int expected2 = 12;

            int actual2 = rsm.SumRegion(1, 2, 2, 4);
            Assert.AreEqual(expected2, actual2);

            int[][] matrix4 = new int[][]
             {
                new int[] {-1}
             };

            rsm = new RangeSumInTwoDimensionalMatrix(matrix4);
            int expected3 = -1;

            int actual3 = rsm.SumRegion(0, 0, 0, 0);
            Assert.AreEqual(expected3, actual3);

            int[][] matrix5 = new int[][]
          {
                new int[] {-4, -5}
          };

            rsm = new RangeSumInTwoDimensionalMatrix(matrix5);
            int expected4 = -4;

            //[0,0,0,0],[0,0,0,1],[0,1,0,1]
            int actual4 = rsm.SumRegion(0, 0, 0, 0);

            Assert.AreEqual(expected4, actual4);

            int expected5 = -9;
            int actual5 = rsm.SumRegion(0, 0, 0, 1);

            Assert.AreEqual(expected5, actual5);

            int expected6 = -5;
            int actual6 = rsm.SumRegion(0, 1, 0, 1);

            Assert.AreEqual(expected6, actual6);
        }

        [TestMethod]
        public void FindMaxChunksSortedTest()
        {
            MaxChunksToSorted maxChunksToSorted = new MaxChunksToSorted();

            int[] arr = new int[] { 1, 0, 2, 3, 4 };
            int expected = 4;

            int actual = maxChunksToSorted.FindMaxChunks(arr);
            Assert.AreEqual(expected, actual);
        }        

        [TestMethod]
        public void FindUniquepathsTest()
        {
            UniquePaths uniquePaths = new UniquePaths();

            int expected = 28;

            int actual = uniquePaths.FindUniquePaths(3, 7);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumOfAllSubMatrices()
        {
            SubmatrixSum submatrixSum = new SubmatrixSum();

            int[][] arr = new int[][] { new int[] { 0, 1 }, new int[] { 0, 1 } };
            int expected = 8;

            /*Dry Run
             * Submatrices possible
                - [0], [1], [0], [1]
                - [0,1], [0,1], [0,0], [0,1], [1,0], [1,1]                
             */

            int actual = submatrixSum.FindSumOfAllSubMatrices(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMaxChunksToSortedII()
        {
            MaxChunksToSortedII chunksToSortedII = new MaxChunksToSortedII();

            int[] arr = new int[] { 5, 4, 3, 2, 1 };
            int expected = 1;

            int actual = chunksToSortedII.MaxChunksToSorted(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiagonalMatrixSumTest()
        {
            MatrixDiagonalSum matrixDiagonalSum = new MatrixDiagonalSum();

            int[][] arr = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}
            };
            int expected = 25;

            int actual = matrixDiagonalSum.GetMatrixDiagonalSum(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinSwapRequired()
        {
            MinimumSwapsRequired msr = new MinimumSwapsRequired();

            int[] arr1 = { 2, 7, 9, 5, 8, 7, 4 };
            int expected = 2;

            int actual = msr.MinSwap(arr1, arr1.Length, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
