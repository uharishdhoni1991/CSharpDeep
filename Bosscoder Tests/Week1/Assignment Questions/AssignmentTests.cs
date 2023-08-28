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
    }
}
