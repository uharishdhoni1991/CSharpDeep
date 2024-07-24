using Bosscoder_MAQ.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bosscoder_Tests.All.MAQ.Arrays
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void TwoSumTest()
        {
            LT1_TwoSum twoSum = new LT1_TwoSum();

            int[] arr = new int[] { 3, 2, 4 };
            int[] expected = new int[] { 1, 2 };

            int[] actual = twoSum.TwoSum(arr, 6);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneDTo2DTest()
        {
            LT2022_Convert1Dto2D convert = new LT2022_Convert1Dto2D();

            int[] arr = new int[] { 1, 2, 3, 4 };
            int[][] expected = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };

            int[][] actual = convert.Construct2DArray(arr, 2, 2);

           Helpers.CheckMatrixEquality(expected, actual);
        }
    }
}
