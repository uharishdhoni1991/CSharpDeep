using Bosscoder.Week_2.Assignment_Questions;
using Bosscoder.Week_2.Homework_Questions;
using Bosscoder.Week_3.Assignment_Questions;
using Bosscoder.Week_3.Homework_Questions;
using Bosscoder.Week_4.Assignment_Questions;
using Bosscoder.Week_5.Assignment_Questions;
using Bosscoder.Week_6.Assignment_Questions;
using Bosscoder.Week_7_StacksAndQueues.Assignement_Questions;
using Bosscoder.Week1.Assignment_Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        [TestMethod]
        public void PalidromePairsTest()
        {
            PalindromePairs palindromePairs = new PalindromePairs();

            List<string> input = new List<string>()
            {
                "abcd",
                "dcba",
                "lls",
                "s",
                "sssll"
            };

            List<List<int>> expected = new List<List<int>>()
            {
               new List<int>() {0,1},
               new List<int>() {1,0 },
               new List<int>(){3,2},
               new List<int>(){2,4 }
            };

            var actual = palindromePairs.Solve(input);

            CollectionAssert.AreEqual(expected, actual);
        }

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

        [TestMethod]
        public void Stack_MinStack_Test()
        {
            MinStack minStack = new MinStack();

            minStack.Push(2);
            minStack.Push(3);
            minStack.Pop();
            Assert.AreEqual(minStack.GetMin(), 3);
            minStack.Push(1);
            Assert.AreEqual(minStack.GetMin(), 1);
        }

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
    }
}