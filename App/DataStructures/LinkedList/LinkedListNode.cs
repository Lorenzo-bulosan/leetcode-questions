using System;

namespace DataStructures.LinkedList
{
    /// <summary>
    /// Model of a node for a singly linked list assuming each node value is unique
    /// </summary>
    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        // override with basic method that assumes unique value in list
        public override bool Equals(Object nodeToCompare)
        {
            LinkedListNode node = nodeToCompare as LinkedListNode;
            return (Value == node.Value);
        }
    }
}
