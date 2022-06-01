using DataStructures.LinkedList;
using DataStructures.LinkedList.Questions.Q2_AddTwoNumbers;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTests.LinkedListTests.Q2AddTwoNumbers
{
    class Q2AddTwoNumbersShould
    {
        private ILinkedList l1;
        private ILinkedList l2;
        private IQ2Solution _sut;

        [SetUp]
        public void Setup()
        {
            // create nodes for linked list 1
            LinkedListNode l1node1 = new() { Value = 2 };
            LinkedListNode l1node2 = new() { Value = 4 };
            LinkedListNode l1node3 = new() { Value = 9 };
            // map linked list 1
            l1node1.Next = l1node2;
            l1node2.Next = l1node3;

            // create nodes for linked list 2
            LinkedListNode l2node1 = new() { Value = 5 };
            LinkedListNode l2node2 = new() { Value = 9 };
            // map linked list 2
            l2node1.Next = l2node2;

            // create linkedlist 1 and set up its head node
            l1 = new SinglyLinkedList();
            l2 = new SinglyLinkedList();
            l1.HeadNode = l1node1;
            l2.HeadNode = l2node1;

            // instantiate subject under test
            _sut = new AddTwoNumbers();
        }
        [Test]
        public void ReturnCorrect_Sum_AsLinkedList()
        {
            // create resulting linkedlist
            LinkedListNode r1 = new() { Value = 7 };
            LinkedListNode r2 = new() { Value = 3 };
            LinkedListNode r3 = new() { Value = 0 };
            LinkedListNode r4 = new() { Value = 1 };

            // linked the nodes
            r1.Next = r2; r2.Next = r3; r3.Next = r4;
            ILinkedList expectedResult = new SinglyLinkedList();
            expectedResult.HeadNode = r1;

            // run the solution
            LinkedListNode output = _sut.Solution(l1.HeadNode, l2.HeadNode);

            // compare
            while(expectedResult.HeadNode != null)
            {
                // test each
                if (output.Value != expectedResult.HeadNode.Value)
                {
                    Console.WriteLine($"You did this:{output.Value}, but we want this {expectedResult.HeadNode.Value}");
                    Assert.Fail();
                }
                Console.WriteLine($"You did this:{output.Value}, we correctly got this:{expectedResult.HeadNode.Value}");
                // keep moving
                output = output.Next;
                expectedResult.HeadNode = expectedResult.HeadNode.Next;
            }
            Assert.Pass();
        }
    }
}
