using LeetCodeV2.Daily_Problems;
using LeetCodeV2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_UnitTests
{
    [TestClass]
    public class LinkedListV2Test
    {
        [TestMethod]
        public void ReverseLinkedListTest()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(2);
            myLinkedList.AddAtTail(3);

            myLinkedList.Head = myLinkedList.ReverseLinkedList();

            string reverseListString = myLinkedList.ToString();
            string expected = "-3--2--1-";
            Assert.AreEqual(reverseListString, expected);
        }

        [TestMethod]
        public void RemoveLinkedListElementsTest()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(2);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtTail(2);
            myLinkedList.AddAtTail(4);          

            myLinkedList.Head = myLinkedList.RemoveLinkedListElements(myLinkedList.Head, 2);

            string listString = myLinkedList.ToString();
            string expected = "-1--3--4-";
            Assert.AreEqual(listString, expected);
        }

        [TestMethod]
        public void CheckMaxSatisfaction()
        {
            ReducingDishes red = new ReducingDishes();
            int max = red.MaxSatisfaction(new int[] { -1, -8, 0, 5, -9 });
            Assert.AreEqual(max, 14);

            int max1 = red.MaxSatisfaction(new int[] { 1, 0, -1, -8, -9 });
            Assert.AreEqual(max1, 2);
        }

        //[TestMethod]
        //Todo
        //public void AssertOddEvenLinkedList()
        //{
        //    MyLinkedList myLinkedList = new MyLinkedList();
        //    myLinkedList.AddAtHead(1);
        //    myLinkedList.AddAtTail(2);
        //    myLinkedList.AddAtTail(3);
        //    myLinkedList.AddAtTail(4);
        //    myLinkedList.AddAtTail(5);

        //    var node = myLinkedList.OddEvenLinkedList(myLinkedList.Head);
        //    string expected = "-1--3--5--2--4-";
        //    Assert.AreEqual(expected, node.ToString());
        //}

        [TestMethod]
        public void SearchInRotatedSortedArrray()
        {
            SearchInRotatedSortedArray sIRA = new SearchInRotatedSortedArray();

            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int expected = 4;
            int actual = sIRA.Search(nums, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInRotatedSortedArrraySingleInput()
        {
            SearchInRotatedSortedArray sIRA = new SearchInRotatedSortedArray();

            int[] nums = new int[] { 1 };
            int expected = 0;
            int actual = sIRA.Search(nums, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInRotatedSortedArrrayDoubleInput()
        {
            SearchInRotatedSortedArray sIRA = new SearchInRotatedSortedArray();

            int[] nums = new int[] { 1, 3 };
            int expected = 1;
            int actual = sIRA.Search(nums, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInRotatedSortedArrrayTripleInput()
        {
            SearchInRotatedSortedArray sIRA = new SearchInRotatedSortedArray();

            int[] nums = new int[] { 1, 3, 5};
            int expected = 2;
            int actual = sIRA.Search(nums, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductExceptSelfTest()
        {
            ProductOfArrayExceptSelf prod = new ProductOfArrayExceptSelf();
            int[] arr = new int[] { 5, 7, 3, 2 };

            int[] actual = prod.ProductExceptSelf(arr);

            CollectionAssert.AreEqual(new int[] { 42, 30, 70, 105 }, actual);
        }

        [TestMethod]
        public void ContiguousArrayTest()
        {
            /*ToDo : Fix Later*/
            //ContiguousArray ca = new ContiguousArray();
            //int[] arr = new int[] { 0, 1, 0 };

            //int actual = ca.FindMaxLength(arr);
            //Assert.AreEqual(2, actual);

            //arr = new int[] { 0, 1};

            //actual = ca.FindMaxLength(arr);
            //Assert.AreEqual(2, actual);

            //arr = new int[] { 0, 0, 1, 0, 0, 0, 1, 1 };

            //actual = ca.FindMaxLength(arr);
            //Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void MinNumberOfArrows()
        {
            LT452_MinNumOfArrowsToBurstBalloons minArrows = new LT452_MinNumOfArrowsToBurstBalloons();

            int[][] arr = new int[][] { new int[] { 10, 16 }, new int[] { 2, 8 }, new int[] { 1, 6 }, new int[] { 7, 12 } };

            int actual = minArrows.FindMinArrowShots(arr);

            Assert.AreEqual(2, actual);

            arr = new int[][] {
                new int[] { 3, 9 },
                new int[] { 7, 12 },
                new int[] { 3, 8 },
                new int[] { 6, 8 },
                new int[] { 9, 10 },
                new int[] { 2, 9 },
                new int[] { 0, 9 },
                new int[] { 3, 9 },
                new int[] { 0, 6 },
                new int[] { 2, 8 } };


            actual = minArrows.FindMinArrowShots(arr);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void SubArrayProdLessThanK()
        {
            LT713_SubArrayProdLessThanK subArray = new LT713_SubArrayProdLessThanK();

            int[] arr = new int[] { 10, 5, 2, 6 };

            int expected = 8;
            int actual = subArray.NumSubarrayProductLessThanK(arr, 100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxSubarrayLengthTest()
        {
            LT2958_LengthOfLongestSubArrayWithAtMostFrequencyK subArray = new LT2958_LengthOfLongestSubArrayWithAtMostFrequencyK();

            int[] arr = new int[] { 1, 2, 3, 1, 2, 3, 1, 2 };

            int expected = 6;
            int actual = subArray.MaxSubarrayLength(arr, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}