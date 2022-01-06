using LeetCode.Linked_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_UnitTests
{
    [TestClass]
    public class LinkedListTest
    {
        private LinkedListCycle _linkedListCycleOne;
        private LinkedListCycle _linkedListCycleTwo;

        private LinkedListIntersection _linkedListIntersection;
        private LinkedListNthNode _linkedListNthNode;

        private LinkedListReverse _linkedListReverse;

        [TestInitialize]
        public void Initialise()
        {
            _linkedListCycleOne = new LinkedListCycle();
            _linkedListCycleTwo = new LinkedListCycle();
            _linkedListIntersection = new LinkedListIntersection();
            _linkedListNthNode = new LinkedListNthNode();
            _linkedListReverse = new LinkedListReverse();
        }

        [TestMethod]
        public void CheckForSingleElementNoCycle()
        {
            _linkedListCycleOne.AddAtHead(1);            
            Assert.IsFalse(_linkedListCycleOne.HasCycle(_linkedListCycleOne.Head));
            Assert.IsNull(_linkedListCycleOne.DetectCycle(_linkedListCycleOne.Head));
        }

        [TestMethod]
        public void CheckForTwoElementNoCycle()
        {
            _linkedListCycleOne.AddAtHead(1);
            _linkedListCycleOne.AddAtHead(2);
            Assert.IsFalse(_linkedListCycleOne.HasCycle(_linkedListCycleOne.Head));
            Assert.IsNull(_linkedListCycleOne.DetectCycle(_linkedListCycleOne.Head));
        }

        [TestMethod]
        public void CheckForTwoElementCycle()
        {
            _linkedListCycleOne.AddAtHead(1);

            Node newNode = new Node(2, _linkedListCycleOne.Head);
            _linkedListCycleOne.AddAtTail(newNode);

            Assert.IsTrue(_linkedListCycleOne.HasCycle(_linkedListCycleOne.Head));
            Assert.AreEqual(_linkedListCycleOne.DetectCycle(_linkedListCycleOne.Head).Val, _linkedListCycleOne.Head.Val);
        }

        [TestMethod]
        public void CheckForThreeElementCycle()
        {
            _linkedListCycleOne.AddAtHead(1);

            Node newNode = new Node(2);
            _linkedListCycleOne.AddAtTail(newNode);

            newNode = new Node(3, _linkedListCycleOne.Head);
            _linkedListCycleOne.AddAtTail(newNode);

            Assert.IsTrue(_linkedListCycleOne.HasCycle(_linkedListCycleOne.Head));
            Assert.AreEqual(_linkedListCycleOne.DetectCycle(_linkedListCycleOne.Head).Val, _linkedListCycleOne.Head.Val);
        }

        [TestMethod]
        public void CheckForFourElementCycleConnectingToIndexOne()
        {
            _linkedListCycleOne.AddAtHead(3);

            Node cycleNode = new Node(2);
            _linkedListCycleOne.AddAtTail(cycleNode);

            Node newNode = new Node(0);
            _linkedListCycleOne.AddAtTail(newNode);

            newNode = new Node(-4, cycleNode);
            _linkedListCycleOne.AddAtTail(newNode);

            Assert.IsTrue(_linkedListCycleOne.HasCycle(_linkedListCycleOne.Head));
            Assert.AreEqual(_linkedListCycleOne.DetectCycle(_linkedListCycleOne.Head), cycleNode);
        }

        [TestMethod]
        public void CheckForTwoElementIntersection()
        {
            int expectedVal = 2;
            ListNode expectedNode = new ListNode(expectedVal);

            _linkedListIntersection.HeadOne = new ListNode(1);
            _linkedListIntersection.HeadOne.Next = expectedNode;

            _linkedListIntersection.HeadTwo = new ListNode(3);
            _linkedListIntersection.HeadTwo.Next = expectedNode;

            Assert.AreEqual(_linkedListIntersection.GetIntersectionNode(_linkedListIntersection.HeadOne, _linkedListIntersection.HeadTwo).Val, expectedVal);
        }

        [TestMethod]
        public void CheckForTwoVsFourIntersection()
        {            
            int expectedVal = 2;
            ListNode expectedNode = new ListNode(expectedVal);

            _linkedListIntersection.HeadOne = new ListNode(1);
            _linkedListIntersection.HeadOne.Next = expectedNode;

            _linkedListIntersection.HeadTwo = new ListNode(3);
            _linkedListIntersection.HeadTwo.Next = expectedNode;
            _linkedListIntersection.HeadTwo.Next.Next = new ListNode(4);
            _linkedListIntersection.HeadTwo.Next.Next.Next = new ListNode(5);

            Assert.AreEqual(_linkedListIntersection.GetIntersectionNode(_linkedListIntersection.HeadOne, _linkedListIntersection.HeadTwo).Val, expectedVal);
        }
        
        [TestMethod]
        public void CheckForFiveVsSixIntersection()
        {           
            int expectedVal = 8;
            ListNode expectedNode = new ListNode(expectedVal);

            _linkedListIntersection.HeadOne = new ListNode(4);
            _linkedListIntersection.HeadOne.Next = new ListNode(1);
            _linkedListIntersection.HeadOne.Next.Next = expectedNode;
            _linkedListIntersection.HeadOne.Next.Next.Next = new ListNode(4);
            _linkedListIntersection.HeadOne.Next.Next.Next.Next = new ListNode(5);

            _linkedListIntersection.HeadTwo = new ListNode(5);
            _linkedListIntersection.HeadTwo.Next = new ListNode(6);
            _linkedListIntersection.HeadTwo.Next.Next = new ListNode(1);
            _linkedListIntersection.HeadTwo.Next.Next.Next = expectedNode;
            _linkedListIntersection.HeadTwo.Next.Next.Next.Next = new ListNode(4);
            _linkedListIntersection.HeadTwo.Next.Next.Next.Next.Next = new ListNode(5);

            Assert.AreEqual(_linkedListIntersection.GetIntersectionNode(_linkedListIntersection.HeadOne, _linkedListIntersection.HeadTwo).Val, expectedVal);
        }

        [TestMethod]
        public void CheckForRemovalOfFirstNodeFromLast()
        {
            int expectedVal = 8;
            ListNode expectedNode = new ListNode(expectedVal);

            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = expectedNode;

            ListNode modifiedHead = _linkedListNthNode.RemoveNthFromEnd(head, 1);

            while (modifiedHead.Next != null)
            {
                Assert.AreNotEqual(expectedNode, modifiedHead);
                modifiedHead = modifiedHead.Next;
            }
        }

        [TestMethod]
        public void CheckForProperLinkedListReversal()
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);

            ListNode modifiedHead = _linkedListReverse.ReverseList(head);
            Assert.AreEqual(modifiedHead, "3,2,1,");
        }
    }
}
