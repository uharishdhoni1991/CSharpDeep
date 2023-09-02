using Arrays;
using LeetCodeV2.Daily_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LeetCode_UnitTests
{
    [TestClass]
    public class ArrayTest
    {
        private ArrayFunc _arrayFunc;

        [TestInitialize]
        public void ArrayInitialise()
        {
            _arrayFunc = new ArrayFunc();
        }

        [TestMethod]
        public void Array_ContainDuplicates()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            bool expected = true;

            bool actual = _arrayFunc.ContainsDuplicateHashsetVersion(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_IsUnique()
        {
            int[] nums = new int[] { 1, 2, 3, 14 };
            bool expected = false;

            bool actual = _arrayFunc.ContainsDuplicateHashsetVersion(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_ContainsDuplicate_FullLength()
        {
            int[] nums = GenerateNumbers();
            bool expected = false;

            bool actual = _arrayFunc.ContainsDuplicateHashsetVersion(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_ContainsDuplicate_FullLength_HashSet()
        {
            int[] nums = GenerateNumbers();
            bool expected = false;

            bool actual = _arrayFunc.ContainsDuplicateHashsetVersion(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_ContainsDuplicate_FullLength_SortedArrayVersion()
        {
            int[] nums = GenerateNumbers();
            bool expected = false;

            bool actual = _arrayFunc.ContainsDuplicateSortedArrayVersion(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_ContainDuplicates_SortedArrayVersion()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            bool expected = true;

            bool actual = _arrayFunc.ContainsDuplicateHashsetVersion(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_MissesANumber()
        {
            int[] nums = new int[] { 0, 1 };
            int expected = 2;

            int actual = _arrayFunc.MissingNumber(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_MissesANumber_SingleInput()
        {
            int[] nums = new int[] { 1 };
            int expected = 0;

            int actual = _arrayFunc.MissingNumber(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Array_MissesANumber_Zero()
        {
            int[] nums = new int[] { 1, 2 };
            int expected = 0;

            int actual = _arrayFunc.MissingNumber(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountNoOfOnesTest()
        {
            CountingNoOfOnes countingNoOfOnes = new CountingNoOfOnes();

            int num = 5;
            int[] expected = new int[] { 0, 1, 1, 2, 1, 1 };

            int[] actual = countingNoOfOnes.CountNoOfOnes(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindromeTest()
        {
            IsPalindromeNumber isPalindromeNumber = new IsPalindromeNumber();

            int num = 121;
            bool expected = true;

            bool actual = isPalindromeNumber.IsPalindrome(num);
            Assert.AreEqual(expected, actual);

            int num1 = -121;
            bool expected1 = false;

            bool actual1 = isPalindromeNumber.IsPalindrome(num1);
            Assert.AreEqual(expected1, actual1);

            int num2 = 10;
            bool expected2 = false;

            bool actual2 = isPalindromeNumber.IsPalindrome(num2);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void RomanToNumberTest()
        {
            string s = "IV";
            int expected = 4;

            int actual = _arrayFunc.ConvertRomanToNumber(s);
            Assert.AreEqual(expected, actual);
        }

        private int[] GenerateNumbers()
        {
            int[] resultantArray = new int[(2 * (int)Math.Pow(10, 5)) + 1];
            int initialNumber = -(int)Math.Pow(10, 5);

            for (int i = 0; i < ((int)Math.Pow(10, 5)); i++)
            {
                resultantArray[i] = initialNumber;
                ++initialNumber;
            }

            resultantArray = resultantArray.Where(x => x != 0).ToArray();

            return resultantArray;
        }
    }
}