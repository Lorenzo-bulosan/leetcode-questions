using DataStructures.LinkedList;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests.LinkedListTest
{
    /// <summary>
    /// After implementing the linkedlist class it should be able to pass all of these test
    /// </summary>
    public class LinkedListShould
    {
        private ILinkedList _sut;

        [SetUp]
        public void Setup()
        {
            // create test nodes in nemory
            LinkedListNode node1 = new() { Value = 1 };
            LinkedListNode node2 = new() { Value = 2 };
            LinkedListNode node3 = new() { Value = 3 };
            LinkedListNode node4 = new() { Value = 4 };
            LinkedListNode node5 = new() { Value = 5 };
            LinkedListNode node6 = new() { Value = 6 };

            // map nodes creating the actual linked list
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            // instantiate subject under test and set it up
            _sut = new SinglyLinkedList();
            _sut.HeadNode = node1; // this and smoke test should run if interface implemented

        }

        #region Smoke test        
        [Test]
        public void AbleTo_Access_NextNode()
        {
            var nextNode = _sut.HeadNode.Next;
            int nextNodeValue = nextNode.Value;
            int expectedValue = 2;

            Assert.That(nextNodeValue, Is.EqualTo(expectedValue));
        }
        #endregion

        /// As it is not a console you can test here
        [Test]
        public void ScratchPad()
        {
            var checkMe = _sut;
            var headNodeValue = _sut.HeadNode.Value;
            var secondNodeValue = _sut.HeadNode.Next.Value;
        }

        #region Unit tests
        // TraverseAll()
        [Test]
        public void WhenCalling_TraverseAll_ReturnCorrectIntList()
        {
            var representationList = _sut.TraverseAll();
            List<int> expectedValue = new() { 1, 2, 3, 4, 5, 6 };

            Assert.That(representationList, Is.EqualTo(expectedValue));
        }
        
        // Peak()
        [Test]
        public void WhenCalling_Peek_ReturnCorrectIntList()
        {
            List<int> oldList = _sut.TraverseAll();
            _sut.Peek();
            List<int> representativeList = _sut.TraverseAll();
            int expectedLenght = 5;            
            int oldLenght = 6;            

            Assert.AreEqual(representativeList.Count, expectedLenght);
            Assert.AreEqual(oldList.Count, oldLenght);
        }
        
        // Push()
        [Test]
        public void WhenCalling_Push_ReturnCorrectHeadNode()
        {
            _sut.Push(99); // creates new head
            int newHeadValue = _sut.HeadNode.Value; 

            int expectedValue = 99;

            Assert.AreEqual(expectedValue, newHeadValue);
        }        
        
        // Append()
        [Test]
        public void WhenCalling_Append_ReturnCorrectResultingList()
        {
            _sut.Append(100);
            var representationList2 = _sut.TraverseAll();
            List<int> expectedValue = new() { 1, 2, 3, 4, 5, 6, 100};

            Assert.AreEqual(expectedValue, representationList2);
        }        
        
        // Delete()
        [Test]
        public void WhenCalling_Delete_ReturnCorrectList()
        {
            LinkedListNode nodeToRemove = new LinkedListNode() { Value = 3 };
            _sut.RemoveNode(nodeToRemove);
            var representationList = _sut.TraverseAll();
            List<int> correctList = new() { 1, 2, 4, 5, 6 };

            Assert.AreEqual(correctList, representationList);
        }
        #endregion
    }
}