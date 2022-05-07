using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Questions.Q206_ReverseLinkedList.Implementations
{
    /// <summary>
    /// My implementation of the solution to the Leetcode question 206
    /// https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public class ReverseLinkedListSolution1 : IQ206Solution
    {
        public LinkedListNode Solution(LinkedListNode head)
        {
            LinkedListNode previousNode = null;
            LinkedListNode currentNode = head;
            LinkedListNode nextNode = null;

            // traverse
            while (currentNode != null) // takes care of empty list too
            {
                nextNode = currentNode.Next; // more information below

                // swap
                currentNode.Next = previousNode;

                // update location
                previousNode = currentNode;
                currentNode = nextNode;
            }           
            return previousNode;
        }
    }
}
/**
 * Explanation:
 * Important position as if you update it below witht the rest then the current node will have moved and when trying to update nextNode it will be null
 * and null doesn't have null.Next.
 * Alternative you can update it below in the same group but needs an IF statement to handle it to see if next is null but also
 * you need to remember that because you exist after the IF then you miss the last Swap. 
 * Here is less problems but confusing to why not grouped with the rest of the updates;
 **/