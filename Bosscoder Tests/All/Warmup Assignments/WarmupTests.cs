using Bosscoder.Week_2.Assignment_Questions;
using Bosscoder.Week_2.Warmup_Questions;
using Bosscoder.Week_3.Warmup_Questions;
using Bosscoder.Week1;
using Bosscoder.Week1.Warmup_Assignments;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder_Tests
{
    [TestClass]
    public class WarmupTests
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            IList<string> actualList = fizzBuzz.PrintFizzBuzz(3);
            IList<string> expectedList = new List<string> { "1", "2", "Fizz" };

            CollectionAssert.AreEqual((System.Collections.ICollection)expectedList, (System.Collections.ICollection)actualList);

            IList<string> actualList5 = fizzBuzz.PrintFizzBuzz(5);
            IList<string> expectedList5 = new List<string> { "1", "2", "Fizz", "4", "Buzz" };

            CollectionAssert.AreEqual((System.Collections.ICollection)expectedList5, (System.Collections.ICollection)actualList5);

            IList<string> actualList15 = fizzBuzz.PrintFizzBuzz(15);
            IList<string> expectedList15 = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            CollectionAssert.AreEqual((System.Collections.ICollection)expectedList15, (System.Collections.ICollection)actualList15);
        }

        [TestMethod]
        public void SumOfDiagonalsTest()
        {
            MatrixDiagonalSum mds = new MatrixDiagonalSum();

            int[][] input3 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            int actualSum = mds.DiagonalSum(input3);

            int expectedSum = 25;
            Assert.AreEqual(expectedSum, actualSum);

            int[][] input4 = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } };
            int expectedSum4 = 8;

            int actualSum4 = mds.DiagonalSum(input4);
            Assert.AreEqual(expectedSum4, actualSum4);
        }


        [TestMethod]
        public void GetConcatenationTest()
        {
            ArrayConcatenation arrayConcatenation = new ArrayConcatenation();

            int[] input2 = new int[] { 1, 2, 1 };
            int[] expectedArray = new int[] { 1, 2, 1, 1, 2, 1 };

            int[] actualArray = arrayConcatenation.GetConcatenation(input2);
            CollectionAssert.AreEqual(expectedArray, actualArray);

            int[] input6 = new int[] { 1, 2, 1, 1, 2, 1 };
            int[] expectedArray6 = new int[] { 1, 2, 1, 1, 2, 1, 1, 2, 1, 1, 2, 1 };

            int[] actualArray12 = arrayConcatenation.GetConcatenation(input6);
            CollectionAssert.AreEqual(expectedArray6, actualArray12);
        }

        [TestMethod]
        public void FindMostWordsFoundTest()
        {
            MostWordsFound mwf = new MostWordsFound();

            string[] sentences = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            int expectedMWF = 6;

            int actualMWF = mwf.FindMostWordsFound(sentences);
            Assert.AreEqual(expectedMWF, actualMWF);

            string[] sentences3 = new string[] { "please wait", "continue to fight", "continue to win" };
            int expectedMWF3 = 3;

            int actualMWF3 = mwf.FindMostWordsFound(sentences3);
            Assert.AreEqual(expectedMWF3, actualMWF3);
        }

        [TestMethod]
        public void RichestCustomerTest()
        {
            RichestCustomerWealth rcw = new RichestCustomerWealth();
            int[][] accounts = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };

            int expected = 6;
            int actual = rcw.MaximumWealth(accounts);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void RunningSumTest()
        {
            RunningSum rs = new RunningSum();
            int[] nums = new int[] { 1, 2, 3, 4 };

            int[] expected = new int[] { 1, 3, 6, 10 };
            int[] actual = rs.GenerateRunningSum(nums);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpecialPositionsCountTest()
        {
            SpecialPositionsInMatrix spm = new SpecialPositionsInMatrix();

            int[][] matrix = new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 0, 0 } };
            int expected = 1;

            int actual = spm.NumSpecial(matrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertOneDtoTwoArray()
        {
            SingleToTwoDimensionalArray singleToTwoDimensionalArray = new SingleToTwoDimensionalArray();

            int[] array = new int[] { 1, 2, 3, 4 };
            int[][] expected = new int[][] { new int[] { 1, 2, }, new int[] { 3, 4 } };

            int[][] actual = singleToTwoDimensionalArray.Construct2DArray(array, 2, 2);

            Helpers.CheckMatrixEquality(expected, actual);

            int[] array2 = new int[] { 1, 2 };
            int[][] expected2 = new int[][] { };

            int[][] actual2 = singleToTwoDimensionalArray.Construct2DArray(array2,1,1);

            Helpers.CheckMatrixEquality(expected2, actual2);
        }

        [TestMethod]
        public void FindGCDTest()
        {
            GreatestCommonDivisor gcd = new GreatestCommonDivisor();
            int[] arr = new int[] {2 ,5 ,6 , 9 , 10};
            int expected = 2;

            int actual = gcd.FindGreatestCommonDivisor(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelfDividingNumbersTest()
        {
            SelfDividingNumbers sdm = new SelfDividingNumbers();

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] actual = sdm.ExtractSelfDividingNumbers(1, 10).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GoodPairsCountTest()
        {
            GoodPairsCount goodPairsCount = new GoodPairsCount();
            int[] arr = new int[] { 0, 1, 2, 0, 1, 2 };
            int expected = 3;            

            int actual = goodPairsCount.GetGoodPairsCount(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubstractProductAndSumTest()
        {
            SubstractProductAndSum sps = new SubstractProductAndSum();
            int num = 156;
            int expected = 18;

            int actual = sps.GetDifferenceOfProductAndSum(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCountOfMatchesTest()
        {
            CountOfMatchesInTournament cmt = new CountOfMatchesInTournament();
            int numOfTeams = 7;
            int expected = 6;

            int actual = cmt.GetMatchCountInTournament(numOfTeams);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxConsecutiveOnes()
        {
            MaxConsecutiveOnes maxConsecutiveOnes = new MaxConsecutiveOnes();
            int[] arr = new int[] { 0, 1, 1, 0, 1, 1, 1 };
            int expected = 3;

            int actual = maxConsecutiveOnes.GetMaxConsecutiveOnes(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}