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
    }
}