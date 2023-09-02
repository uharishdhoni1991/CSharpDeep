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
    }
}
