using Bosscoder.Week1;
using Bosscoder.Week1.Warmup_Assignments;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
    }
}
