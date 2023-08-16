using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tutor_Challenges;

namespace TutorUnitTests
{
    [TestClass]
    public class TutorUnitTests
    {
        Challenges _tutorChallenge = new Challenges();

        [TestMethod]
        public void TestMaxOfThreeElements()
        {
            int[] array = new int[] { 3, 1, 2 };
            int actualMax = _tutorChallenge.FindMaxOfThreeElements(array);
            int expectedMax = 3;

            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        public void TestMinOfThreeElements()
        {
            int[] array = new int[] { 3, 1, 2 };
            int actualMin = _tutorChallenge.FindMinOfThreeElements(array);
            int expectedMin = 1;

            Assert.AreEqual(expectedMin, actualMin);
        }

        [TestMethod]
        public void TestMidOfThreeElements()
        {
            int[] array = new int[] { 3, 1, 2 };
            int actualMid = _tutorChallenge.FindMidElementOfThreeElements(array);
            int expectedMid = 2;

            Assert.AreEqual(expectedMid, actualMid);
        }

        [TestMethod]
        public void TestPrintSeries()
        {
            string expectedSeries =
                "1\n" +
                "1 2\n" +
                "1 2 3\n" +
                "1 2 3 4\n" +
                "1 2 3 4 5";

            string actualSeries = _tutorChallenge.PrintSeries(5);

            Assert.AreEqual(expectedSeries, actualSeries);
        }

        [TestMethod]
        public void TestPrintSeriesReverse()
        {
            string expectedSeries =
                "1 2 3 4 5\n" +
                "1 2 3 4\n" +
                "1 2 3\n" +
                "1 2\n" +
                "1";

            string actualSeries = _tutorChallenge.PrintReverseSeries(5);

            Assert.AreEqual(expectedSeries, actualSeries);
        }

        [TestMethod]
        public void TestReturnAllOddElements()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            int[] actualOddElements = _tutorChallenge.FindAllOddElements(array);

            int[] expectedOddElements = new int[] { 1, 3, 5 };

            for (int i = 0; i < actualOddElements.Length; i++)
            {
                Assert.AreEqual(expectedOddElements[i], actualOddElements[i]);
            }
        }

        [TestMethod]
        public void TestFindSumOfArrayElements()
        {
            int[] array = new int[] { 1, 3, 4, 5, 6 };

            double actualSum = _tutorChallenge.FindSumOfArrayElements(array);

            double expectedSum = 19;

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void TestFirstEvenNumber()
        {
            int[] expectedOneArray = new int[] { 1, 2, 6, 3, 5 };
            int[] expectedTwoArray = new int[] { 1, 7, 9, 3, 5 };
            int[] expectedThirdArray = new int[] { 1, 7, 4, 8, 5 };

            int actualOne = _tutorChallenge.FindFirstEvenNumber(expectedOneArray);
            int actualTwo = _tutorChallenge.FindFirstEvenNumber(expectedTwoArray);
            int actualThree = _tutorChallenge.FindFirstEvenNumber(expectedThirdArray);

            int expectedOne = 2;
            int expectedTwo = -1;
            int expectedThree = 4;

            Assert.AreEqual(expectedOne, actualOne);
            Assert.AreEqual(expectedTwo, actualTwo);
            Assert.AreEqual(expectedThree, actualThree);
        }
    }
}
