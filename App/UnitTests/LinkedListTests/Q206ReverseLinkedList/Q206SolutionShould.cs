using DataStructures.LinkedList;
using DataStructures.LinkedList.Questions.Q206_ReverseLinkedList;
using NUnit.Framework;
using System.Collections.Generic;

class Q206SolutionShould
{
    private ILinkedList _linkedList;
    private IQ206Solution _sut;

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

        // create link list and set up its head node
        _linkedList = new SinglyLinkedList();
        _linkedList.HeadNode = node1; // this and smoke test should run if interface implemented

        // instantiate subject under test
        _sut = new ReverseLinkedList();
    }

    [Test]
    public void Return_Correct_ReversedList()
    {        
        List<int> reversedList = new();
        List<int> expectedOuputVal = new() { 6, 5, 4, 3, 2, 1 };

        var outputNode = _sut.Solution(_linkedList.HeadNode);

        while (outputNode != null)
        {
            reversedList.Add(outputNode.Value);
            outputNode = outputNode.Next;
        }

        Assert.That(expectedOuputVal, Is.EqualTo(reversedList));
    }
    [Test]
    public void Return_Empty_WhenListToReverse_IsEmpty()
    {
        List<int> reversedList = new();
        ReverseLinkedList localSut = new();

        var outputNode = localSut.Solution(null);

        while (outputNode != null)
        {
            reversedList.Add(outputNode.Value);
            outputNode = outputNode.Next;
        }
        if (reversedList.Count == 0) reversedList = null; 

        Assert.That(null, Is.EqualTo(reversedList));
    }
    [Test]
    public void Return_CorrectList_WhenOnlyOneNode()
    {
        ReverseLinkedList localSut = new();
        SinglyLinkedList oneValueList = new();
        oneValueList.HeadNode = new LinkedListNode() { Value = -9999 };
        List<int> reversedList = new();
        List<int> expectedOuputVal = new() { -9999 };

        var outputNode = localSut.Solution(oneValueList.HeadNode);

        while (outputNode != null)
        {
            reversedList.Add(outputNode.Value);
            outputNode = outputNode.Next;
        }

        Assert.That(expectedOuputVal, Is.EqualTo(reversedList));
    }
}