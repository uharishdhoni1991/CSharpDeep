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

        [TestMethod]
        public void AssertOddEvenLinkedList()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(2);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtTail(4);
            myLinkedList.AddAtTail(5);

            var node = myLinkedList.OddEvenLinkedList(myLinkedList.Head);
            string expected = "-1--3--5--2--4-";
            Assert.AreEqual(expected, node.ToString());
        }

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
    }
}