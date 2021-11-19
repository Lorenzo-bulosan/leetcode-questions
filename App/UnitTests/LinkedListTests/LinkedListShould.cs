using DataStructures.LinkedList;
using NUnit.Framework;

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
            //var checkMe = _sut;
            //var headNodeValue = _sut.HeadNode.Value;
            //var secondNodeValue = _sut.HeadNode.Next.Value;
        }

        #region Unit tests
        // TraverseAll()
        [Test]
        public void WhenCalling_TraverseAll_ReturnCorrectIntList()
        {
            //var representationList = _sut.TraverseAll();
            //List<int> expectedValue = new List<int>() {1,2,3,4,5,6};

            //Assert.That(representationList, Is.EqualTo(expectedValue));
        }
        
        // Peak()
        [Test]
        public void WhenCalling_Peak_ReturnCorrectIntList()
        {

        }
        
        [Test]
        public void WhenCalling_Peak_ReturnCorrectOutParameter()
        {

        }
        
        // Push()
        [Test]
        public void WhenCalling_Push_ReturnCorrectHeadNode()
        {

        }
        #endregion
    }
}