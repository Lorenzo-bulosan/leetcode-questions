using System.Collections.Generic;

/// <summary>
/// This models the linked list expected behaviour, you can write your own class that implements this
/// </summary>
namespace DataStructures.LinkedList
{
    /// <summary>
    /// Interfaces that models a singly linked list with basic behaviours
    /// </summary>
    public interface ILinkedList
    {
        /// <summary>
        /// Property to set and return the head node of the list.
        /// </summary>
        LinkedListNode HeadNode { get; set; }

        /// <summary>
        /// Method to go through all the nodes in the list.
        /// Return a List<int> to visualise it as the linked list itself is in memory.
        /// </summary> 
        /// <returns></returns>
        List<int> TraverseAll();

        /// <summary>
        /// Method to get value of the head node and remove it from the list. 
        /// Return head node value.
        /// </summary>
        /// <returns></returns>
        int Peek();

        /// <summary>
        /// Method to create a node and insert at the FRONT of linked list.
        /// </summary>
        /// <param name="nodeToAdd"></param>
        /// <returns></returns>
        void Push(int valueOfNewNode);

        /// <summary>
        /// Method to create a node and insert at the END of linked list.
        /// </summary>
        /// <param name="nodeToAdd"></param>
        /// <returns></returns>
        void Append(int valueOfNewNode);

        /// <summary>
        /// Removes node from list by comparing values
        /// Assumes values are unique in the whole list
        /// </summary>
        /// <param name="nodeToAdd"></param>
        /// <returns></returns>
        void RemoveNode(LinkedListNode nodeToRemove);
    }
}