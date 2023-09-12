using Bosscoder.Week_2.Homework_Questions;
using Bosscoder.Week1.Homework_Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bosscoder_Tests.Week1.Homework_Questions
{
    [TestClass]
    public class HomeworkTests
    {
        [TestMethod]
        public void MaxSubArrayTest()
        {
            MaxSubArrayProb maxSubArray = new MaxSubArrayProb();

            int[] input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int expectedMax = 6;

            int actualMax = maxSubArray.MaxSubArray(input);
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        public void SetZeroesTest()
        {
            SetMatrixZeroes setMatrixZeroes = new SetMatrixZeroes();

            int[][] input = new int[][] {
                new int[] { 1, 1, 1},
                new int[] {1, 0, 1},
                new int[] { 1, 1, 1 }};

            int[][] expectedOut = new int[][] {
                new int[] { 1, 0, 1},
                new int[] {0, 0, 0},
                new int[] { 1, 0, 1 }};

            int[][] actualOut = setMatrixZeroes.SetZeroes(input);

            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expectedOut[i][j], actualOut[i][j]);
                j++;

                if (j == 3)
                    j = 0;
            }
        }

        [TestMethod]
        public void LongestSubArrayTest()
        {
            LongestSubArrayWithMaxLength lsa = new LongestSubArrayWithMaxLength();

            int[] input = new int[] { 2, 3, 4, -1, -2, 1, 5, 6, 3 };
            int expectedOut = 4;

            int actualOut = lsa.LongestSubArray(input);
            Assert.AreEqual(expectedOut, actualOut);

            int[] input2 = new int[] { 4979, -522, 987, 23,324, -1489 ,-187 };
            int expectedOut2 = 3;

            int actualOut2 = lsa.LongestSubArray(input2);
            Assert.AreEqual(expectedOut2, actualOut2);            
        }

        [TestMethod]
        public void PermutationTest()
        {
            Permutations perm = new Permutations();

            int[] input = new int[] { 1, 2, 3 };
            int[,] expectedOut = perm.FindPermutations(input);
        }

        [TestMethod]
        public void FindNegativeElementCount()
        {
            CountNegativeNumbersInASortedMatrix cnsm = new CountNegativeNumbersInASortedMatrix();

            int[][] matrix = new int[][] {
                new int[] { 4, 3, 2, -1 },
                new int[] { 3, 2, 1, -1 },
                new int[] { 1, 1, -1, -2 },
                new int[] { -1, -1, -2, -3 }
            };
            int expected = 8;

            int actual = cnsm.FindNegativeElementCount(matrix);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TransposeMatrixTest()
        {
            TransposeMatrix tm = new TransposeMatrix();

            int[][] matrix = new int[][]
            {
                new int[] {2,4,-1},
                new int[]{-10,5,11},
                new int[]{18,-7,6}
            };

            int[][] expected = new int[][]
            {
                new int[] {2,-10,18},
                new int[]{4,5,-7},
                new int[]{-1,11,6}
            };

            int[][] actual = tm.GetMatrixTranspose(matrix);

            Helpers.CheckMatrixEquality(expected, actual);

            int[][] matrix2 = new int[][]
            {
                new int[] {1,2,3},
                new int[]{4,5,6}                
            };

            int[][] expected1 = new int[][]
            {
                new int[] {1,4},
                new int[]{2,5},
                new int[]{3,6}
            };

            int[][] actual1 = tm.GetMatrixTranspose(matrix2);

            Helpers.CheckMatrixEquality(expected1, actual1);

        }

        [TestMethod]
        public void ReshapeAMatrixTest()
        {
            ReshapeMatrix reshapeMatrix = new ReshapeMatrix();

            int[][] matrix = new int[][]
            {
                new int[] {1,2,3},
                new int[]{4,5,6},
                new int[]{7,8,9}
            };

            int[][] expected = new int[][] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };

            int[][] actual = reshapeMatrix.MatrixReshape(matrix, 1, 9);
            Helpers.CheckMatrixEquality(expected, actual);

            int[][] matrix1 = new int[][]
            {
                new int[] {1,2},
                new int[] {3,4}                
            };

            int[][] expected1 = new int[][]
            {
               new int[] {1,2},
                new int[] {3,4}
            };

            int[][] actual1 = reshapeMatrix.MatrixReshape(matrix1, 2, 4);
            Helpers.CheckMatrixEquality(expected1, actual1);
        }

        [TestMethod]
        public void TestSortArray()
        {
            MinimumSwapsRequired min = new MinimumSwapsRequired();

            int[] arr = new int[] { 0, 1, 1, 0 };
            //min.SortedArray(arr);
        }
    }
}
