using DataStructures.LinkedList;
using DataStructures.LinkedList.Questions.Q141_LinkedListCycle;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests.LinkedListTests.Q141DetectCycle
{
    public class Q141SolutionShould
    {
        private ILinkedList _linkedList;
        private IQ141Solution _sut;

        [SetUp]
        public void Setup()
        {
            // create test nodes in nemory
            var node1 = new LinkedListNode() { Value = 1 };
            var node2 = new LinkedListNode() { Value = 2 };
            var node3 = new LinkedListNode() { Value = 3 };
            var node4 = new LinkedListNode() { Value = 4 };
            var node5 = new LinkedListNode() { Value = 5 };
            var node6 = new LinkedListNode() { Value = 6 };

            // map nodes creating the actual linked list
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node4;

            // create link list and set up its head node
            _linkedList = new SinglyLinkedList();
            _linkedList.HeadNode = node1; // this and smoke test should run if interface implemented

            // instantiate subject under test
            _sut = new LinkedListCycle();
        }

        [Test]
        public void DetectsCycle_Correctly()
        {
            bool isCycled = _sut.Solution(_linkedList.HeadNode);
            bool expected = true;
            Assert.AreEqual(expected, isCycled);
        }
        [Test]
        public void DetectsNoCycle_Correctly()
        {
            // local linked list no cycle
            var local1 = new LinkedListNode() { Value = 1 };
            var local2 = new LinkedListNode() { Value = 2 };
            var local3 = new LinkedListNode() { Value = 3 };
            var local4 = new LinkedListNode() { Value = 4 };
            local1.Next = local2; local2.Next = local3; local3.Next = local4;

            bool isCycled = _sut.Solution(local1);
            bool expected = false;
            Assert.AreEqual(expected, isCycled);
        }
    }
}
