using Bosscoder.Week_2.Homework_Questions;
using Bosscoder.Week_3.Assignment_Questions;
using Bosscoder.Week_3.Homework_Questions;
using Bosscoder.Week_4.Homework_Questions;
using Bosscoder.Week_5.Homework_Questions;
using Bosscoder.Week_6.Homework_Questions;
using Bosscoder.Week_8_LinkedList;
using Bosscoder.Week_8_LinkedList.HomeWork_Questions;
using Bosscoder.Week1.Homework_Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder_Tests.Homework_Questions
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

        [TestMethod]
        public void PeopleInQueueTest()
        {
            PeopleInQueue p = new PeopleInQueue();
            long expected = 16;

            long actual = p.GetNPosition((long)16);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DoesRectangleOverlapTest()
        {
            RectangleOverlap rectangleOverlap = new RectangleOverlap();
            bool expected = true;

            bool actual = rectangleOverlap.DoesRectanglesOverlap(
                new int[] { 0, 0, 2, 2 },
                new int[] { 1, 1, 3, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetZeroesInFactorial()
        {
            CountTrailingZeroesInFactorial ctz = new CountTrailingZeroesInFactorial();
            int expected = 2;

            int actual = ctz.TrailingZeroes(10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PermutationSequenceTest()
        {
            PermutationSequence ps = new PermutationSequence();
            string expected = "1324";

            string actual = ps.GetSequence(4, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NthMagicalTest()
        {
            NthMagicalNumber nthMagicalNumber = new NthMagicalNumber();
            int expected = 2;

            int actual = nthMagicalNumber.GetNthMagicalNumber(1, 2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNthMagicalNumberUsingUniquePowOf5()
        {
            FindNthMagicalNumber findNthMagicalNumber = new FindNthMagicalNumber();
            int expected = 130;

            int actual = findNthMagicalNumber.FIndNthMagicalNumberPow5(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            DivideTwoIntegers divideTwoIntegers = new DivideTwoIntegers();
            double expected = 2;

            double actual = divideTwoIntegers.GetQuotient(5, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BitDifferencesTest()
        {
            BitDifferences bitDifferences = new BitDifferences();
            int[] arr = new int[] { 1, 3, 5 };

            int expected = 8;
            int actual = bitDifferences.GetSumOfBitDifferences(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleElementAsZeroTest()
        {
            CheckIfArrayCanBeMadeSingleElementAsZero ca = new CheckIfArrayCanBeMadeSingleElementAsZero();
            int[] input = new int[] { 1, 1, 2, 2, 3 };

            bool expected = false;
            bool actual = ca.OnlyMergeAndSplit(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XORQueriesTest()
        {
            XORQueries xORQueries = new XORQueries();
            int[] input = new int[] {1, 3, 4, 8};
            int[][] queries = new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] {0, 3 },
                new int[] {3, 3} };

            int[] expected = new int[] { 2, 7, 14, 8 };
            int[] actual = xORQueries.GetQueryXORResult(input, queries);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TotalHammingDistanceTest()
        {
            HammingDistance hammingDistance = new HammingDistance();

            int[] input = new int[] {4, 14, 2};
            int expected = 6;
            int actual = hammingDistance.TotalHammingDistance(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search2DMatrixTest()
        {
            Search2DMatrix search = new Search2DMatrix();

            int[][] matrix = new int[][] {
                new int[] {1, 3, 5, 7},
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
                };

            bool expected = false;
            bool actual = search.SearchMatrix(matrix, 3);
        }

        [TestMethod]
        public void PreImageSizeTest()
        {
            PreImageSize preImageSize = new PreImageSize();

            int expected = 5;
            int actual = preImageSize.PreImageSizeFZF(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainerWithMostWaterTest()
        {
            ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();

            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int expected = 49;

            int actual = containerWithMostWater.Solve(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTriangleNumberTest()
        {
            ValidTriangleNumber validTriangleNumber = new ValidTriangleNumber();

            int[] input = new int[] { 2, 2, 3, 4 };
            int expected = 3;

            int actual = validTriangleNumber.GetCount(input);
            Assert.AreEqual(expected, actual);

            input = new int[] { 4, 2, 3, 4 };
            expected = 4;

            actual = validTriangleNumber.GetCount(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KClosestNumbersTest()
        {
            FindKClosestElements findKClosestElements = new FindKClosestElements();
            int[] input = new int[] { 1, 2, 3, 4, 5 };

            int[] expected = new int[] { 1, 2, 3, 4 };
            int[] actual = findKClosestElements.Solve(input, 4, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KpairsWithSmallSUmTest()
        {
            FindKPairsWithSmallestSums findKPairs = new FindKPairsWithSmallestSums();
            int[] input = new int[] { 1, 7, 11 };
            int[] input2 = new int[] { 2, 4, 6 };

            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>(){1,2},
                new List<int>(){1,4},
                new List<int>(){1,6}
            };

            var actual = findKPairs.Solve(input, input2, 3);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i][0], actual[i][0]);
                Assert.AreEqual(expected[i][1], actual[i][1]);
            }
        }

        [TestMethod]
        public void HashMapDesignTest()
        {
            DesignHashMap myHashMap = new DesignHashMap();

            myHashMap.Put(1, 1);
            myHashMap.Put(2, 2); 
            Assert.AreEqual(1, myHashMap.Get(1));
            Assert.AreEqual(-1, myHashMap.Get(3));    
            myHashMap.Put(2, 1); 
            Assert.AreEqual(1, myHashMap.Get(2));    
            myHashMap.Remove(2); 
            Assert.AreEqual(-1, myHashMap.Get(2));
        }

        [TestMethod]
        public void SetMatrixZeroesTest()
        {
            SetMatrixZeroesHashing setMatrixZeroes = new SetMatrixZeroesHashing();

            int[][] input = new int[][] {
                new int[] {1,1,1 },
                new int[] {1,0,1 },
                new int[] {1,1,1}};

            setMatrixZeroes.Solve(input);
        }

        [TestMethod]
        public void FindSumInArrayTest()
        {
            FindPairSumInArray findPairSumInArray = new FindPairSumInArray();

            int[] input = new int[] { 1, 2, 3 };

            var expected = new List<List<int>>()
            {
                new List<int>() {1,2}
            };

            var actual = findPairSumInArray.Solve(input);
            Helpers.CheckMatrixEquality(expected.Select(x => x.ToArray()).ToArray(), actual.Select(x => x.ToArray()).ToArray());
        }        

        [TestMethod]
        public void BitManipulation_SumOfIntegers_Test()
        {
            SumOfTwoIntegers sumOfTwoIntegers = new SumOfTwoIntegers();

            int expected = 3;
            int actual = sumOfTwoIntegers.Sum(2, 1);

            Assert.AreEqual(expected, actual);
        }            
        
        [TestMethod]
        public void Linear_KokoEatingBananas_Test()
        {
            KokoEatingBananas kokoEatingBananas = new KokoEatingBananas();

            int[] input = new int[] { 3, 6, 7, 11 };
            int expected = 4;

            int actual = kokoEatingBananas.Solve(input, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Recursion_BackTracking_LetterCombinationInPhone()
        {
            LetterCombinationInPhoneNumber letterCombinationInPhoneNumber = new LetterCombinationInPhoneNumber();

            string s = "23";
            List<string> expected = new List<string>()
            {
                "ad","ae","af","bd","be","bf","cd","ce","cf"
            };

            List<string> actual = letterCombinationInPhoneNumber.Solve(s).ToList();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxUnitsOnATruck_Test()
        {
            MaxUnitsOnATruck maxUnitsOnATruck = new MaxUnitsOnATruck();

            int[][] input = new int[][] { new int[] { 1, 2 }, new int[] { 1, 3 } };
            int expected = 3;

            int actual = maxUnitsOnATruck.MaximumUnits(input, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxProfitAssignment_Test()
        {
            MaxProfitAssignment maxProfitAssignment = new MaxProfitAssignment();

            int[] difficulty = new int[] { 2, 4, 6, 8, 10 };
            int[] profit = new int[] { 10, 20, 30, 40, 50 };
            int[] worker = new int[] { 4, 5, 6, 7 };

            int expected = 100;
            int actual = maxProfitAssignment.GetMaxProfitAssignment(
                difficulty,
                profit,
                worker);

            Assert.AreEqual(expected, actual);
        }
    }
}