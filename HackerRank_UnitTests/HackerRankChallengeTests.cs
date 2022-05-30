using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_UnitTests
{
    [TestClass]
    public class HackerRankChallengeTests
    {
        Challenges _hackerRankChallenges;

        [TestInitialize]
        public void Initialise()
        {
           _hackerRankChallenges  = new Challenges();
        }

        [TestMethod]
        public void CompareTriplets()
        {
            List<int> a = new List<int>()
            {
                5,
                6,
                7
            };

            List<int> b = new List<int>()
            {
                3,
                6,
                10
            };
           
            _hackerRankChallenges.CompareTriplets(a, b);
        }

        [TestMethod]
        public void MiniMaxSumMaxInputs()
        {
            List<int> inputList = new List<int>() { 256741038, 623958417, 467905213, 714532089 ,938071625 };
            _hackerRankChallenges.MiniMaxSum(inputList);
        }

        [TestMethod]
        public void MiniMaxSumEqualInputs()
        {
            List<int> inputList = new List<int>()
            {
                5,
                5,
                5,
                5,
                5
            };

            _hackerRankChallenges.MiniMaxSum(inputList);
        }

        [TestMethod]
        public void MiniMaxSumInitialInputs()
        {
            List<int> inputList = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };

            _hackerRankChallenges.MiniMaxSum(inputList);
        }

        [TestMethod]
        public void GetCandlesWhichCanBeBlownOff()
        {
            int expected = 1;
            List<int> inputList = new List<int>() { 1, 3, 4, 4, 5 };

            int actual = _hackerRankChallenges.BirthdayCakeCandles(inputList);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForGradeUpdates()
        {
            List<int> inputList = new List<int>() { 40, 37, 73, 70, 82 };
            List<int> expectedList = new List<int>() { 40, 37, 75, 70, 82};

            List<int> actualList = _hackerRankChallenges.GradingStudents(inputList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void TestApplesAndOranges()
        {
            var expected = "1\r\n1\r\n";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            _hackerRankChallenges.CountApplesAndOranges(7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 });

            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKangarooJumpWontCoincidence()
        {
            var expected = "NO";            

            string actual = _hackerRankChallenges.KangarooJump(0, 2, 5, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBetweenTwoSets()
        {
            List<int> arr = new List<int> { 2, 4};
            List<int> brr = new List<int> { 16, 32, 96};

            int total = _hackerRankChallenges.GetTotalX(arr, brr);

            Assert.AreEqual(total, 3);
        }    
    }
}
