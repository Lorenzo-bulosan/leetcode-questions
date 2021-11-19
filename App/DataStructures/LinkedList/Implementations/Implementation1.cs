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

            // edge case: empty list
            if(HeadNode == null)
            {
                HeadNode = newNode;
                return;
            }

            // traversing linked list
            while (currentNode != null)
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
                    break;
                }
            }
        }

        public int Peek()
        {
            //edge case: empty list
            if (HeadNode == null) return -999999999;

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

            // edge case: empty list
            if (HeadNode == null)
            {
                HeadNode = newNode;
                return;
            }

            // swap head
            newNode.Next = HeadNode;
            HeadNode = newNode;
        }

        public void RemoveNode(LinkedListNode nodeToRemove)
        {
            // edge case: empty list
            if (HeadNode == null) return;

            LinkedListNode currentNode = HeadNode;
            LinkedListNode lastNode = null;
            LinkedListNode nextNode = currentNode.Next;            

            // edge case: single node in entire list or end of list
            if (currentNode.Next == null)
            {
                HeadNode = null;
                return;
            }

            // traverse
            while (true)
            {                         
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

            // traverse and covers empty linklist edge cases
            while (currentNode != null)
            {
                listOfNodeValues.Add(currentNode.Value);

                // while not last change tracker position
                if (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                else
                {                  
                    break;
                }
            }
            return listOfNodeValues;
        }
    }
}
