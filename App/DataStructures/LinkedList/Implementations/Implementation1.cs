using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// My implementation of a singly linked list
/// </summary>
namespace DataStructures.LinkedList.Implementations
{
    public class Implementation1 : ILinkedList
    {
        public LinkedListNode HeadNode { get; set; }

        public void Append(int valueOfNewNode)
        {
            List<int> listOfNodeValues = new();
            LinkedListNode newNode = new() { Value = valueOfNewNode};
            LinkedListNode currentNode = HeadNode;
            bool isLast = false;

            // traversing linked list
            while (!isLast)
            {
                // to output
                listOfNodeValues.Add(currentNode.Value);

                // while not last change tracker position
                if (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                else
                {
                    // point current to new
                    currentNode.Next = newNode;
                    isLast = true;
                }
            }
        }

        public int Peek()
        {
            // tmp value for swapping
            LinkedListNode oldHead = HeadNode;
            HeadNode = HeadNode.Next;

            // unlink old head
            oldHead.Next = null;
            return oldHead.Value;
        }

        public void Push(int valueOfNewNode)
        {
            // create node
            LinkedListNode newNode = new();
            newNode.Value = valueOfNewNode;
            newNode.Next = HeadNode;

            // change head
            HeadNode = newNode;
        }

        public void RemoveNode(LinkedListNode nodeToRemove)
        {
            LinkedListNode currentNode = HeadNode;
            LinkedListNode lastNode = null;
            LinkedListNode nextNode = currentNode.Next; 

            // traverse
            while (true)
            {
                // edge case: single node in entire list or end of list
                if (currentNode.Next == null) return;

                // edge case: removing head node
                if (nodeToRemove.Equals(HeadNode))
                {
                    //unlinks head and next node becomes head
                    HeadNode.Next = null;
                    nextNode = HeadNode;
                }

                // when you find node to remove
                if (nodeToRemove.Equals(currentNode))
                {
                    // unlink current from list and make lastnode point to nextnode
                    currentNode.Next = null;
                    lastNode.Next = nextNode;
                    break;
                }                

                // update location untill found
                lastNode = currentNode;
                currentNode = nextNode;
                nextNode = currentNode.Next;
            }
        }

        public List<int> TraverseAll()
        {
            List<int> listOfNodeValues = new();
            LinkedListNode currentNode = HeadNode;

            bool isLast = false;

            while (!isLast)
            {
                listOfNodeValues.Add(currentNode.Value);

                // while not last change tracker position
                if (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                else
                {
                    isLast = true;
                }
            }
            return listOfNodeValues;
        }
    }
}
