using LeetCode.Linked_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_UnitTests
{
    [TestClass]
    public class LinkedListCycleTest
    {
        private LinkedListCycle _linkedListCycle;

        [TestInitialize]
        public void Initialise()
        {
            _linkedListCycle = new LinkedListCycle();
        }

        [TestMethod]
        public void CheckForSingleElementNoCycle()
        {
            _linkedListCycle.AddAtHead(1);            
            Assert.IsFalse(_linkedListCycle.HasCycle(_linkedListCycle.Head));
        }

        [TestMethod]
        public void CheckForTwoElementNoCycle()
        {
            _linkedListCycle.AddAtHead(1);
            _linkedListCycle.AddAtHead(2);
            Assert.IsFalse(_linkedListCycle.HasCycle(_linkedListCycle.Head));
        }

        [TestMethod]
        public void CheckForTwoElementCycle()
        {
            _linkedListCycle.AddAtHead(1);

            Node newNode = new Node(2, _linkedListCycle.Head);
            _linkedListCycle.AddAtTail(newNode);

            Assert.IsTrue(_linkedListCycle.HasCycle(_linkedListCycle.Head));
        }

        [TestMethod]
        public void CheckForThreeElementCycle()
        {
            _linkedListCycle.AddAtHead(1);

            Node newNode = new Node(2);
            _linkedListCycle.AddAtTail(newNode);

            newNode = new Node(3, _linkedListCycle.Head);
            _linkedListCycle.AddAtTail(newNode);

            Assert.IsTrue(_linkedListCycle.HasCycle(_linkedListCycle.Head));
        }
    }
}
