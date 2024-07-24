using Bosscoder.Models;
using Bosscoder.Week_10_Trees.Assignment_Questions;
using Bosscoder.Week_10_Trees.Homework_Questions;
using Bosscoder.Week_12_Greedy.Assignment_Questions;
using Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions;
using Bosscoder.Week_2.Assignment_Questions;
using Bosscoder.Week_2.Homework_Questions;
using Bosscoder.Week_3.Assignment_Questions;
using Bosscoder.Week_4.Assignment_Questions;
using Bosscoder.Week_5.Assignment_Questions;
using Bosscoder.Week_6.Assignment_Questions;
using Bosscoder.Week_7_StacksAndQueues.Assignement_Questions;
using Bosscoder.List.Assignment_Questions;
using Bosscoder.Week_9_RecursionAndBackTracking;
using Bosscoder.Week_9_RecursionAndBackTracking.Assignement_Questions;
using Bosscoder.Week1.Assignment_Questions;
using Bosscoder.Week11_TriesAndHeaps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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
            int[] arr6 = new int[] { 8, 8 };

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
                    Assert.AreEqual(expectedMatrix[i][j], actualMatrix[i][j]);
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

        [TestMethod]
        public void LargestCoPrimeTest()
        {
            LargestCoPrime lcp = new LargestCoPrime();

            int expected = 5;
            int actual = lcp.GetLargestCoPrime(15, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateRandFromAnotherRand()
        {
            Rand10FromRand7 rand10FromRand7 = new Rand10FromRand7();

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int actual = rand10FromRand7.Rand10();

            Assert.IsTrue(expected.Contains(actual));

            int actual1 = rand10FromRand7.Rand10ProbabilityApproach();

            Assert.IsTrue(expected.Contains(actual1));
        }

        [TestMethod]
        public void SumOfDivisorsTest()
        {
            SumOfDivisorsOnlyIfTotalDivisorsIsFour sd = new SumOfDivisorsOnlyIfTotalDivisorsIsFour();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int expected = 45;
            int actual = sd.SumOFDivisorsOfCountFour(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalNoOfDivisors()
        {
            TotalNumberOfDivisors tnd = new TotalNumberOfDivisors();
            int expected = 2;

            int actual = tnd.GetTotalNumberoFDivisors(5);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void RectangleAreaTest()
        {
            RectangleArea rectangleArea = new RectangleArea();
            int expected = 45;

            int actual = rectangleArea.GetRectangleArea(
                ax1: -3, ay1: 0, ax2: 3, ay2: 4, bx1: 0, by1: -1, bx2: 9, by2: 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfPairsAreDivisibleByKTest()
        {
            CheckIfPairsDivisibleByK checkIfPairsDivisibleByK = new CheckIfPairsDivisibleByK();
            bool expected = false;

            bool actual = checkIfPairsDivisibleByK.CanArrange(new int[] { 1, 2, 3, 4, 5, 6 }, 5);
            Assert.AreEqual(expected, actual);

            expected = false;

            actual = checkIfPairsDivisibleByK.CanArrange(new int[] { 1, 2, 3, 4, 5, 6 }, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCountOfSubarraysDivByKTest()
        {
            NumberOfSubsequencesWhoseSumIsDivisibleByK nsk = new NumberOfSubsequencesWhoseSumIsDivisibleByK();
            int expected = 2;

            int actual = nsk.GetNoOfSequences(new int[] { 1, 1, 1 }, 2);
            Assert.AreEqual(expected, actual);

            int expected1 = 0;

            int actual1 = nsk.GetNoOfSequences(new int[] { 1 }, 0);
            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod]
        public void FindSingleNumber()
        {
            SingleNumber fsn = new SingleNumber();
            int expected = 6;

            int actual = fsn.FindSingleNumber(new int[] { 1, 1, 3, 3, 4, 5, 4, 5, 6, 7, 7, 8, 8 });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseBitsTest()
        {
            ReverseBits reverseBits = new ReverseBits();
            string input = "00000010100101000001111010011100";

            int expected = 964176192;
            int actual = reverseBits.GetReversedInteger(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleNum2()
        {
            SingleNum2 singleNum2 = new SingleNum2();
            int[] input = new int[] { 2, 2, 3, 2 };

            int expected = 3;
            int actual = singleNum2.Find(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleNume3()
        {
            SingleNumber3 singleNumber3 = new SingleNumber3();
            int[] input = new int[] { 1, 1, 2, 2, 3, 3, 4, 5 };

            int[] expected = new int[] { 4, 5 };
            int[] actual = singleNumber3.Process(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberOfOneBits()
        {
            NumberOf1Bits numberOfOneBits = new NumberOf1Bits();
            string input = "00000000000000000000000000001011";

            int expected = 3;
            int actual = numberOfOneBits.Solve(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInRotatedSortedArrayTest()
        {
            SearchInRotatedSortedArray sra = new SearchInRotatedSortedArray();
            int[] input = new int[] { 4, 5, 6, 7, 0, 1, 2 };

            int expected = 4;
            int actual = sra.Solve(input, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindFirsLastPositionInSortedArrayTest()
        {
            FirstLastSortedPosition flp = new FirstLastSortedPosition();
            int[] input = new int[] { 5, 7, 7, 8, 8, 10 };

            int[] expected = new int[] { 3, 4 };
            int[] actual = flp.SearchRange(input, 8);

            CollectionAssert.AreEqual(expected, actual);

            expected = new int[] { -1, -1 };
            actual = flp.SearchRange(input, 6);

            CollectionAssert.AreEqual(expected, actual);

            input = new int[] { 1 };
            expected = new int[] { 0, 0 };
            actual = flp.SearchRange(input, 1);

            CollectionAssert.AreEqual(expected, actual);

            input = new int[] { 1, 2, 3 };
            expected = new int[] { 1, 1 };
            actual = flp.SearchRange(input, 2);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindPeakTest()
        {
            FindPeakElement fpe = new FindPeakElement();
            int[] input = new int[] { 1, 2, 3, 1 };

            int expected = 2;
            int actual = fpe.FindPeak(input);

            Assert.AreEqual(expected, actual);

            input = new int[] { 1, 2, 1, 3, 5, 6, 4 };

            expected = 5;
            actual = fpe.FindPeak(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNonDuplicateElement()
        {
            SingleNonDuplicate singleNonDuplicate = new SingleNonDuplicate();
            int[] input = new int[] { 1, 1, 2, 2, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

            int expected = 3;
            int actual = singleNonDuplicate.GetSingleNonDuplicate(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MagneticForceTest()
        {
            MagneticForceBetweenBalls mfb = new MagneticForceBetweenBalls();
            int[] input = new int[] { 5, 4, 3, 2, 1, 1000000000 };

            int expected = 1000000000 - 1;
            int actual = mfb.MinMagneticForceBetweenBalls(input, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SmallestBaseTest()
        {
            SmallestBase smallestBase = new SmallestBase();
            string input = "13";

            string expected = "3";
            string actual = smallestBase.smallestGoodBase(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReversePairsTest()
        {
            ReversePairs reversePairs = new ReversePairs();
            int[] input = new int[] { 1, 3, 2, 3, 1 };

            int expected = 2;
            int actual = reversePairs.GetReversePairsCount(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CapacityToShipPackageTest()
        {
            CapacityToShipPackages capacityToShipPackages = new CapacityToShipPackages();
            int[] weights = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int expected = 15;
            int actual = capacityToShipPackages.Solve(weights, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumbersSmallerThanSelfTest()
        {
            CountOfNumbersAfterSelf countOfNumbersAfterSelf = new CountOfNumbersAfterSelf();
            int[] nums = new int[] { 5, 2, 6, 1 };

            int[] expected = new int[] { 2, 1, 1, 0 };
            int[] actual = countOfNumbersAfterSelf.countSmaller(nums).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UglyNumber2()
        {
            //1,2,3,4,5,6,8,9,10,12
            UglyNumber2 ugly = new UglyNumber2();

            int expected = 1;
            int actual = ugly.NthUglyNumber(1);
            
            Assert.AreEqual(expected, actual);

            int expected1 = 12;
            int actual1 = ugly.NthUglyNumber(10);

            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod]
        public void InputArraySortedIITest()
        {
            InputArraySorted inputArraySorted = new InputArraySorted();

            int[] input = new int[] { 1, 3, 6, 7 };
            int[] expected = new int[] { 1, 2 };

            int[] actual = inputArraySorted.Solve(input, 4);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KDiffPairsTest()
        {
            KDiffPairs kDiffPairs = new KDiffPairs();

            int[] input = new int[] { 3, 1, 4, 1, 5 };
            int expected = 2;

            int actual = kDiffPairs.CountPairsWithDiffK(input,input.Length, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinExpOfThreeSortedArrays()
        {
            MinimizeExpOfThreeSortedArrays minimizeExp = new MinimizeExpOfThreeSortedArrays();
            int[] input1 = new int[] { 1, 4, 5, 8, 10 };
            int[] input2 = new int[] { 6, 9, 15 };
            int[] input3 = new int[] { 2, 3, 6, 6 };

            int expected = 1;
            int actual = minimizeExp.Solve(input1, input2, input3);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void FindMaxLengthofArrayEqualsZero()
        {
            FindLengthOfLargestSubarrayWithZeroSum find = new FindLengthOfLargestSubarrayWithZeroSum();
            int[] input = new int[] { 15, -2, 2, -8, 1, 7, 10, 23 };

            int expected = 5;
            int actual = find.Solve(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestSequenceLengthTest()
        {
            LongestConsecutiveSequence longestConsecutiveSequence = new LongestConsecutiveSequence();
            int[] input = new int[] { 1, 2, 100, 200, 101, 201, 202, 203 };

            int expected = 3;
            int actual = longestConsecutiveSequence.Solve(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AnagramStringTest()
        {
            AnagramString anagramString = new AnagramString();
            string s1 = "Best";
            string s2 = "Best";

            bool expected = true;
            bool actual = anagramString.Solve(s1, s2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidSudokuTest()
        {
            Sudoku sudoku = new Sudoku();

            int[][] board = new int[9][] {
                new int[] {5, 3, 0, 0, 7, 0, 0, 0, 0},
                new int[] {6, 0, 0, 1, 9, 5, 0, 0, 0},
                new int[] {0, 9, 8, 0, 0, 0, 0, 6, 0},
                new int[] {8, 0, 0, 0, 6, 0, 0, 0, 3},
                new int[] {4, 0, 0, 8, 0, 3, 0, 0, 1},
                new int[] {7, 0, 0, 0, 2, 0, 0, 0, 6},
                new int[] {0, 6, 0, 0, 0, 0, 2, 8, 0},
                new int[] {0, 0, 0, 4, 1, 9, 0, 0, 5},
                new int[] {0, 0, 0, 0, 8, 0, 0, 7, 9}
            };

            bool expected = true;
            bool actual = sudoku.Solve(board);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestSubstringTest()
        {
            LongestSubstringWithoutRepeatingChars lst = new LongestSubstringWithoutRepeatingChars();

            string s = "abcbbab";
            int expected = 3;

            int actual = lst.Solve(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimumWindowSubstring()
        {
            MinimumWindowSubstring ms = new MinimumWindowSubstring();

            string input = "this is a test string";
            string pattern = "tist";

            string expected = "t stri";
            string actual = ms.Solve(input, pattern);

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void PalidromePairsTest()
        //{
        //    //Todo

        //    //PalindromePairs palindromePairs = new PalindromePairs();

        //    //List<string> input = new List<string>()
        //    //{
        //    //    "abcd",
        //    //    "dcba",
        //    //    "lls",
        //    //    "s",
        //    //    "sssll"
        //    //};

        //    //List<List<int>> expected = new List<List<int>>()
        //    //{
        //    //   new List<int>() {0,1},
        //    //   new List<int>() {1,0 },
        //    //   new List<int>(){3,2},
        //    //   new List<int>(){2,4 }
        //    //};

        //    //var actual = palindromePairs.Solve(input);

        //    //CollectionAssert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void Stack_EvaluateReversePolishNotation_Test()
        {
            EvalRevPolishNotation evalRevPolishNotation = new EvalRevPolishNotation();

            string[] input = new string[] { "2", "1", "+", "3", "*" };
            int expected = 9;

            int actual = evalRevPolishNotation.Solve(input);
            Assert.AreEqual(expected, actual);

            input = new string[] { "4", "13", "5", "/", "+" };
            expected = 6;

            actual = evalRevPolishNotation.Solve(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_DailyTemperatures_Test()
        {
            DailyTemperatures dailyTemperatures = new DailyTemperatures();

            int[] temp = new int[] { 71, 72, 69, 71, 70, 73, 71, 70 };
            int[] expected = new int[] {1,4,1,2,1,0,0,0 };

            int[] actual = dailyTemperatures.Solve(temp);
            CollectionAssert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Stack_MinStack_Test()
        //{
        //    //Todo : Fix this unit test
        //    //MinStack minStack = new MinStack();

        //    //minStack.Push(2);
        //    //minStack.Push(3);
        //    //minStack.Pop();
        //    //Assert.AreEqual(minStack.GetMin(), 3);
        //    //minStack.Push(1);
        //    //Assert.AreEqual(minStack.GetMin(), 1);
        //}

        [TestMethod]
        public void Stack_ExpressionRedundant_Test()
        {
            ExoressionContainRedundantBracket expressionContain = new ExoressionContainRedundantBracket();

            string s = "(a+b)";
            bool expected = false;

            bool actual = expressionContain.Check(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_LargestRectangleAreaHistogram_Test()
        {
            LargestRectangleHistogram histogram = new LargestRectangleHistogram();

            int[] input = new int[] { 2, 1, 5, 6, 2, 3 };
            int expected = 10;

            int actual = histogram.Solve(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Queue_ImplementQueueUsingStack_Test()
        {
            ImplementQueueUsingStack queueUsingStack = new ImplementQueueUsingStack();

            queueUsingStack.Push(5);
            queueUsingStack.Push(6);
            Assert.AreEqual(5, queueUsingStack.Top());
            queueUsingStack.Push(7);
            Assert.AreEqual(5,queueUsingStack.Pop());
            Assert.AreEqual(6, queueUsingStack.Pop());
            Assert.AreEqual(7, queueUsingStack.Pop());
            Assert.AreEqual(true, queueUsingStack.Empty());
        }

        [TestMethod]
        public void Queue_ImplementStackUsingQueue_Test()
        {
            ImplementStackUsingQueue stackUsingQueue = new ImplementStackUsingQueue();

            stackUsingQueue.Push(5);
            stackUsingQueue.Push(6);
            Assert.AreEqual(6, stackUsingQueue.Top());
            stackUsingQueue.Push(7);
            Assert.AreEqual(7, stackUsingQueue.Pop());
            Assert.AreEqual(6, stackUsingQueue.Pop());
            Assert.AreEqual(5, stackUsingQueue.Pop());
            Assert.AreEqual(true, stackUsingQueue.Empty());
        }

        [TestMethod]
        public void Queue_SlidingWindowMax_Test()
        {
            //SlidingWindowMaximum slidingWindow = new SlidingWindowMaximum();
            //int[] input = new int[] {1,2,3,4,5,6};

            //int[] expected = new int[] { 3, 4, 5, 6 };
            //int[] actual = slidingWindow.Solve(input, 3);

            //CollectionAssert.AreEqual(expected, actual);

            //input = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            //expected = new int[] { 3, 3, 5, 5, 6, 7 };

            //actual = slidingWindow.Solve(input, 3);

            //CollectionAssert.AreEqual(expected, actual);

            //input = new int[] { 9, 10, 9, -7, -4, -8, 2, -6 };
            //expected = new int[] { 10, 10, 9, 2 };

            //actual = slidingWindow.Solve(input, 5);

            //CollectionAssert.AreEqual(expected, actual);

            // Need higher version of C# to implement code 
        }          
        
        [TestMethod]
        public void Stack_LongestValidParantheses_Test()
        {
            LongestValidParantheses longestValid = new LongestValidParantheses();

            string s = "(()";
            int expected = 2;
            int actual = longestValid.Solve(s);

            Assert.AreEqual(expected, actual);

            s = "())";
            expected = 2;
            actual = longestValid.Solve(s);

            Assert.AreEqual(expected, actual);

            s = "(((";
            expected = 0;
            actual = longestValid.Solve(s);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Queue_ButNotUsed_GasStations()
        {
            GasStation gasStation = new GasStation();

            int[] gasStations = new int[] { 1, 2, 3, 4, 5 };
            int[] cost = new int[] { 3, 4, 5, 1, 2 };

            int expected = 3;
            int actual = gasStation.Solve(gasStations, cost);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_Design_Test()
        {
            DesignLinkedList designLinkedList = new DesignLinkedList();

            designLinkedList.AddAtHead(1);
            designLinkedList.AddAtTail(3);
            designLinkedList.AddAtIndex(1, 2);
            Assert.AreEqual(2, designLinkedList.Get(1));

            designLinkedList.DeleteAtIndex(1);
            Assert.AreEqual(3, designLinkedList.Get(1));

            /* ["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
            [[],[1],[3],[1,2],[1],[0],[0]]*/

            designLinkedList = new DesignLinkedList();

            designLinkedList.AddAtHead(1);
            designLinkedList.AddAtTail(3);
            designLinkedList.AddAtIndex(1, 2);

            Assert.AreEqual(2, designLinkedList.Get(1));

            designLinkedList.DeleteAtIndex(0);
            Assert.AreEqual(2, designLinkedList.Get(0));
        }

        [TestMethod]
        public void LinkedList_Middle_Test()
        {
            DesignLinkedList designLinkedList = new DesignLinkedList();

            designLinkedList.AddAtHead(1);
            designLinkedList.AddAtTail(3);
            designLinkedList.AddAtIndex(1, 2);

            MiddleOfLinkedList middleOfLinkedList = new MiddleOfLinkedList();

            int expected = 1;
            int actual = middleOfLinkedList.Solve(designLinkedList.Head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_MergeSorted_Test()
        {            
            Node head1 = new Node(1);
            head1.Next = new Node(2);
            head1.Next.Next = new Node(4);

            Node head2 = new Node(1);
            head2.Next = new Node(3);
            head2.Next.Next = new Node(4);

            Node expected = new Node(1);
            expected.Next = new Node(1);
            expected.Next.Next = new Node(2);
            expected.Next.Next.Next = new Node(3);
            expected.Next.Next.Next.Next = new Node(4);
            expected.Next.Next.Next.Next.Next = new Node(4);

            MergeSortedLinkedLists mergeSortedLinkedLists = new MergeSortedLinkedLists();
            Node actual = mergeSortedLinkedLists.Solve(head1, head2);
            
            while(expected.Next != null && actual.Next != null)
            {
                Assert.AreEqual(expected.Val, actual.Val);
                expected = expected.Next;
                actual = actual.Next;
            }
        }

        [TestMethod]
        public void LinkedList_RemoveNthNode_Test()
        {
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);

            Node expected = new Node(1);
            expected.Next = new Node(3);

            RemoveNthNode removeNthNode = new RemoveNthNode();
            Node actual = removeNthNode.Solve(head, 1);

            while(expected.Next!= null && actual.Next!= null)
            {
                Assert.AreEqual(expected.Val, actual.Val);
                expected = expected.Next;
                actual = actual.Next;
            }
        }

        [TestMethod]
        public void LinkedList_HasCycle_Test()
        {
            Node head = new Node(1);
            Node cyclePoint = new Node(2);
            head.Next = cyclePoint;
            head.Next.Next = new Node(3);
            head.Next.Next.Next = cyclePoint;

            bool expected = true;
            LinkedListCycle linkedListCycle = new LinkedListCycle();
            bool actual = linkedListCycle.HasCycle(head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_CycleNode_Test()
        {
            Node head = new Node(1);
            Node cyclePoint = new Node(2);
            head.Next = cyclePoint;
            head.Next.Next = new Node(3);
            head.Next.Next.Next = cyclePoint;

            int expected = 3;
            LinkedListCycle2 linkedListCycle = new LinkedListCycle2();
            int actual = linkedListCycle.Solve(head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_MergeSortedLinkedList_Test()
        {
            MergeSortedLinkedLists mergeSortedLinkedLists = new MergeSortedLinkedLists();

            Node l1 = new Node(1);
            l1.Next = new Node(2);
            l1.Next.Next = new Node(5);

            Node l2 = new Node(1);
            l2.Next = new Node(2);
            l2.Next.Next = new Node(3);

            Node expected = new Node(1);
            expected.Next = new Node(1);
            expected.Next.Next = new Node(2);
            expected.Next.Next.Next = new Node(2);
            expected.Next.Next.Next.Next = new Node(3);
            expected.Next.Next.Next.Next.Next = new Node(5);

            Node actual = mergeSortedLinkedLists.Solve(l1, l2);
            new Homework_Questions.HomeworkTests().AssertLLResult(expected, actual);
        }

        [TestMethod]
        public void LinkedList_IntersectionLinkedList_Test()
        {
            IntersectionOfSortedLinkedLists inter = new IntersectionOfSortedLinkedLists();

            Node l1 = new Node(1);
            l1.Next = new Node(2);

            Node interNode = new Node(3);
            l1.Next.Next = interNode;
            interNode.Next = new Node(5);


            Node l2 = new Node(4);
            l2.Next = new Node(6);
            l2.Next.Next = interNode;

            Node actual = inter.Solve(l1, l2);

            new Homework_Questions.HomeworkTests().AssertLLResult(interNode, actual);
        }

        [TestMethod]
        public void LinkedList_DeepCopy_Test()
        {
            CopyListWithRandomPointer copyList = new CopyListWithRandomPointer();

            NodeRandom head = new NodeRandom(1);
            var next = new NodeRandom(2);           

            head.Next = next;
            head.Random = null;

            var next1 = new NodeRandom(4);
            

            head.Next.Next = next1;
            head.Next.Random = head; ;

            NodeRandom actual = copyList.Solve(head);

            new Homework_Questions.HomeworkTests().AssertLLResult(head, actual);
        }    

        [TestMethod]
        public void LinkedList_RemoveLinkedList_Test()
        {
            RemoveDuplicatesFromLinkedList remove = new RemoveDuplicatesFromLinkedList();

            Node head = new Node(1);
            head.Next = new Node(1);
            head.Next.Next = new Node(2);

            Node expected = new Node(1);
            expected.Next = new Node(2);

            Node actual = remove.Solve(head);
            new Homework_Questions.HomeworkTests().AssertLLResult(expected, actual);
        }

        [TestMethod]
        public void LinkedList_ReverseLinkedList_Test()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();

            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);

            Node expected = new Node(4);
            expected.Next = new Node(3);
            expected.Next.Next = new Node(2);
            expected.Next.Next.Next = new Node(1);

            Node actual = reverseLinkedList.Solve(head);
            new Homework_Questions.HomeworkTests().AssertLLResult(expected, actual);
        }


        [TestMethod]
        public void LinkedList_RemoveLinkedListElements_Test()
        {
            RemoveLinkedListElements remove = new RemoveLinkedListElements();

            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(1);
            head.Next.Next.Next = new Node(3);
            head.Next.Next.Next.Next = new Node(4);

            Node expected = new Node(2);
            expected.Next = new Node(3);
            expected.Next.Next = new Node(4);

            Node actual = remove.Solve(head, 1);
            new Homework_Questions.HomeworkTests().AssertLLResult(expected, actual);
        }

        [TestMethod]
        public void LinkedList_BinaryToInteger_Test()
        {
            BinaryInLinkedListToInteger binaryToInteger = new BinaryInLinkedListToInteger();

            Node head = new Node(1);
            head.Next = new Node(0);
            head.Next.Next = new Node(0);
            head.Next.Next.Next = new Node(1);

            int expected = 9;
            int actual = binaryToInteger.Solve(head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Recursion_Permutations_Test()
        {
            Permutations permutations = new Permutations();

            List<int> input = new List<int>()
            { 1, 2, 3};

            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>() {1,2,3},
                new List<int>() {1,3,2},
                new List<int>() {2,1,3},
                new List<int>() {2,3,1},
                new List<int>() {3,1,2},
                new List<int>() {3,2,1},
            };

            var actual = permutations.Solve(input);

            Assert.AreEqual(expected.Count, actual.Count);
            for(int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod]
        public void Recursion_PermutationsII_Test()
        {
            PermutationsII permutations = new PermutationsII();

            List<int> input = new List<int>()
            { 1, 1, 2};

            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>() {1,1,2},
                new List<int>() {1,2,1},
                new List<int>() {2,1,1}                
            };

            var actual = permutations.Solve(input.ToArray());

            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod]
        public void Recursion_SubsetsII_Test()
        {
            LT90_SubsetsII lT90_SubsetsII = new LT90_SubsetsII();

            int[] input = new int[] { 1, 2, 2 };
            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>{},
                new List<int>{1},
                new List<int>{1,2},
                new List<int>{1,2,2},
                new List<int>{2},
                new List<int>{2,2}
            };

            var actual = lT90_SubsetsII.Solve(input);

            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod]
        public void Recursion_CombinationSum_Test()
        {
            LT39_CombinationSum combinationSum = new LT39_CombinationSum();

            int[] input = new int[] { 2, 3, 6, 7 };
            int target = 7;

            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>{2,2,3},
                new List<int>{7}                
            };

            var actual = combinationSum.Solve(input, target);

            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod]
        public void Recursion_NQueens_Test()
        {
            LT51_NQueens nQueens = new LT51_NQueens();

            var expected = new List<List<string>>()
            {
                new List<string>{".Q..","...Q","Q...","..Q."},
                new List<string>{"..Q.","Q...","...Q",".Q.."}
            };

            var actual = nQueens.SolveNQueens(4);

            Assert.AreEqual(expected.Count, actual.Count);
            for(int i =0; i < expected.Count; i++)
            {
                for(int j=0; j < actual.Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod]
        public void Trees_InOrderTraversal()
        {
            var tree = new TreeNode(1);
            tree.Right = new TreeNode(2);
            tree.Right.Left = new TreeNode(3);

            List<int> expected = new List<int>() { 1, 3, 2 };
            LT94_InOrderTraversal inOrder = new LT94_InOrderTraversal();

            var actual = inOrder.InorderTraversal(tree);
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void Trees_PreOrderTraversal()
        {
            var tree = new TreeNode(1);
            tree.Right = new TreeNode(2);
            tree.Right.Left = new TreeNode(3);

            List<int> expected = new List<int>() { 1, 2, 3 };
            LT144_PreOrderTraversal preOrder = new LT144_PreOrderTraversal();

            var actual = preOrder.PreorderTraversal(tree);
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void Trees_PostOrderTraversal()
        {
            var tree = new TreeNode(1);
            tree.Right = new TreeNode(2);
            tree.Right.Left = new TreeNode(3);

            List<int> expected = new List<int>() { 3, 2, 1 };
            LT145_PostOrderTraversal preOrder = new LT145_PostOrderTraversal();

            var actual = preOrder.PostorderTraversal(tree);
            CollectionAssert.AreEqual(expected, actual.ToList());
        }    

        [TestMethod]
        public void Trees_MaximumDepthOfTree()
        {
            var tree = new TreeNode(1);
            tree.Right = new TreeNode(2);         
            tree.Left = new TreeNode(4);
            tree.Left.Left = new TreeNode(5);

            int expected = 3;
            LT104_MaximumDepthOfTree maxDepth = new LT104_MaximumDepthOfTree();

            int actual = maxDepth.MaxDepth(tree);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Trees_LevelOrderTraversal()
        {          
            var tree = new TreeNode(3);
            tree.Left = new TreeNode(9);
            tree.Right = new TreeNode(20);
            tree.Right.Left = new TreeNode(15);
            tree.Right.Right = new TreeNode(7);

            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>(){3},
                new List<int>(){9,20},
                new List<int>(){15,7}
            };

            LT102_BinaryTreeLevelOrderTraversal levelOrderTraversal = new LT102_BinaryTreeLevelOrderTraversal();
            var actual = levelOrderTraversal.LevelOrder(tree);

            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod]
        public void Trees_IsBalancedBinaryTree_Test()
        {
            var tree = new TreeNode(3);
            tree.Left = new TreeNode(9);
            tree.Right = new TreeNode(20);
            tree.Right.Left = new TreeNode(15);
            tree.Right.Right = new TreeNode(7);

            LT110_BalancedBinaryTree balanced = new LT110_BalancedBinaryTree();
            bool actual = balanced.IsBalanced(tree);          

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Trees_BTUsingInandPostOrder_Test()
        {
            var tree = new TreeNode(3);
            tree.Left = new TreeNode(9);
            tree.Right = new TreeNode(20);
            tree.Right.Left = new TreeNode(15);
            tree.Right.Right = new TreeNode(7);

            int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            int[] postorder = new int[] { 9, 15, 7, 20, 3 };

            LT106_ConstructBTUsingInandPost construct = new LT106_ConstructBTUsingInandPost();
            var actual = construct.Solve(inorder, postorder);

            Assert.IsTrue(new LT100_SameTree().Solve(tree, actual));
        }

        [TestMethod]
        public void Trees_InorderWithoutRecursion()
        {
            var tree = new TreeNode(1);
            tree.Right = new TreeNode(2);
            tree.Right.Left = new TreeNode(3);

            List<int> expected = new List<int>()
            { 1,3,2};

            GFG_InorderWithoutRecursion inorder = new GFG_InorderWithoutRecursion();
            var actual = inorder.Solve(tree); ;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Tries_Implement_Test()
        {
            var trie = new Trie();
            //trie.ChildNodes = new

            LT208_ImplementTrie trieObj = new LT208_ImplementTrie();
            var t = trieObj.Solve();

            Assert.IsTrue(t.Item1 && t.Item2);

            trie.Insert("apple");
            Assert.IsTrue(trie.Search("apple"));   // return True
            Assert.IsFalse(trie.Search("app"));     // return False
            Assert.IsTrue(trie.StartsWith("app")); // return True
            trie.Insert("app");
            Assert.IsTrue(trie.Search("app"));     // return True
        }

        [TestMethod]
        public void Tries_AddandSearch_Test()
        {
            LT211_DesignAddandSearchDataStructure design = new LT211_DesignAddandSearchDataStructure();
            design.AddWord("bad");
            design.AddWord("dad");
            design.AddWord("mad");
            Assert.IsFalse(design.Search("pad")); // return False
            Assert.IsTrue(design.Search("bad")); // return True
            Assert.IsTrue(design.Search(".ad")); // return True
            Assert.IsTrue(design.Search("b..")); // return True
        }

        [TestMethod]
        public void Greedy_ActivitySelection_Test()
        {
            GFG_ActivitySelection acs = new GFG_ActivitySelection();

            int[] start = new int[] { 10, 12, 20 };
            int[] finish = new int[] { 20, 25, 30 };

            List<int> expected = new List<int>()
            {
                0,
                2
            };

            var actual = acs.Solve(start, finish);
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod]
        public void Greedy_MinimumNoOfPlatforms_Test()
        {
            GFG_MinNoOfPlatformsRequired min = new GFG_MinNoOfPlatformsRequired();

            int[] arr = new int[] { 900, 940, 950, 1100, 1500, 1800 };
            int[] dep = new int[] { 910, 1200, 1120, 1130, 1900, 2000 };

            int expected = 3;
            int actual = min.Solve(arr, dep);

            Assert.AreEqual(expected, actual);

            int actualEfficient = min.SolveEfficiently(arr, dep);
            Assert.AreEqual(expected, actualEfficient);
        }

        [TestMethod]
        public void Greedy_SumOfArrayKNegations_Test()
        {
            LT1005_MaximiseSumOfArrayAfterKNegations maxSum = new LT1005_MaximiseSumOfArrayAfterKNegations();

            int[] input = new int[] { 4, 2, 3 };
            int expected = 5;

            int actual = maxSum.LargestSumAfterKNegations(input, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Greedy_AssignMiceToHoles()
        {
            GFG_AssignMiceToHoles miceHole = new GFG_AssignMiceToHoles();

            int[] mice = new int[] { 4, -4, 2 };
            int[] holes = new int[] { 4, 0, 5 };

            int expected = 4;
            int actual = miceHole.Solve(mice, holes);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Greedy_DistributeCandies()
        {
            LT575_DistributeCandies distribute = new LT575_DistributeCandies();

            int[] candyType = new int[] { 1, 1, 2, 2, 3, 3 };

            int expected = 3;
            int actual = distribute.DistributeCandies(candyType);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Greedy_MaxProductThreeNums()
        {
            LT628_MaxProductOfThreeNumbers maxProd = new LT628_MaxProductOfThreeNumbers();

            int[] input = new int[] {-100, -98, -1, 2, 3, 4};

            int expected = 39200;
            int actual = maxProd.MaximumProduct(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Greedy_BulbSwitcher()
        {
            LT319_BulbSwitcher bulb = new LT319_BulbSwitcher();

            int expected = 1;
            int actual = bulb.BulbSwitch(3);

            Assert.AreEqual(expected, actual);

            int actualOpt = bulb.Solve(3);
            Assert.AreEqual(expected, actualOpt);
        }

        [TestMethod]
        public void DP_DecodeWays_Test()
        {
            LT91_DecodeWays decode = new LT91_DecodeWays();

            string input = "226";
            int expected = 3;
            int actual = decode.NumDecodings(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DP_ClimbStairs()
        {
            LT70_ClimbingStairs climb = new LT70_ClimbingStairs();

            int expected = 3;

            int actualMemo = climb.Memoize(3, Enumerable.Repeat<int>(-1, 4).ToArray());
            Assert.AreEqual(expected, actualMemo);

            int actualTab = climb.Tabulate(3);
            Assert.AreEqual(expected, actualTab);

            int actualSpace = climb.SpaceOptimise(3);
            Assert.AreEqual(expected, actualSpace);
        }

        [TestMethod]
        public void DP_NumberofWaysToPair()
        {
            GFG_NumberOfWaysToPairPeople pair = new GFG_NumberOfWaysToPairPeople();

            int expected = 4;

            int actual = pair.Solve(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DP_RegularExpression()
        {
            LT10_RegularExpressionMatching reg = new LT10_RegularExpressionMatching();

            string input = "aa";
            string pattern = "a*";

            bool expected = true;
            bool actual = reg.SolveDFS(input, pattern);

            Assert.AreEqual(expected, actual);

            bool actualMemo = reg.SolveDFS_Memo(input, pattern);
            Assert.AreEqual(expected, actualMemo);
        }

        [TestMethod]
        public void DP_MinimumPathSum()
        {
            LT64_MinimumPathSum minPathSum = new LT64_MinimumPathSum();

            int[][] mat = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };

            int expected = 7;
            int actual = minPathSum.Solve(mat);

            Assert.AreEqual(expected, actual);

            int actualMemo = minPathSum.SolveMemo(mat);
            Assert.AreEqual(expected, actualMemo);
        }

        [TestMethod]
        public void DP_LongestCommonSubSequence()
        {
            LT1143_LongestCommonSubSequence lcs = new LT1143_LongestCommonSubSequence();

            int expected = 3;
            int actual = lcs.LongestCommonSubsequence("abc", "abc");

            Assert.AreEqual(expected, actual);

            int actualTwo = lcs.LongestCommonSubsequence("abc", "ac");
            Assert.AreEqual(2, actualTwo);
        }

        [TestMethod]
        public void DP_EditDistance_Test()
        {
            LT72_EditDistance editDistance = new LT72_EditDistance();

            int expected = 3;
            int actual = editDistance.MinDistance("horse", "ros");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DP_LongestPalindromicSubsequence_Test()
        {
            LT516_LongestPalindromicSubSequence lps = new LT516_LongestPalindromicSubSequence();

            string input = "malayalam";
            int expected = input.Length;

            int actual = lps.Solve(input);

            Assert.AreEqual(expected, actual);

            int actualTab = lps.SolveTabulation(input);
            Assert.AreEqual(expected, actualTab);
        }

        [TestMethod]
        public void DP_SplitArrayWithSameAvg_Test()
        {
            LT805_SplitArrayWithSameAverage split = new LT805_SplitArrayWithSameAverage();

            int[] input = new int[] { 1, 2, 3 };
            bool actual = split.SplitArraySameAverage(input);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DP_DistinctSubSequence()
        {
            LT115_DistinctSubsequences ds = new LT115_DistinctSubsequences();

            string input = "rabbbit";
            string pattern = "rabbit";

            int expected = 3;
            int actual = ds.NumDistinct(input, pattern);

            Assert.AreEqual(expected, actual);

            expected = 5;
            string input2 = "babgbag";
            string pattern2 = "bag";

            actual = ds.NumDistinct(input2, pattern2);

            Assert.AreEqual(expected, actual);

            expected = 5;         
            actual = ds.NumDistinctMemoized(input2, pattern2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DP_TriangleArray()
        {
            LT120_TriangleArray ta = new LT120_TriangleArray();

            List<IList<int>> triangle = new List<IList<int>> { new List<int>() { 1 }, new List<int>() { 1, 2 } };
            int expected = 2;

            int actual = ta.MinimumTotal(triangle);
            Assert.AreEqual(expected, actual);

            triangle = new List<IList<int>>
            {
                new List<int>() { 2 },
                new List<int>() { 3,4 } ,
                new List<int>() { 6,5,7},
                new List<int>() { 4,1,8,3}
            };

            expected = 11;
            actual = ta.MinimumTotal(triangle);

            Assert.AreEqual(expected, actual);
        }
    }
}