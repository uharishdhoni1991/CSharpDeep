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
    }
}