using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Questions.Q2_AddTwoNumbers.Implementations
{
    /// <summary>
    /// This is my implementation for the Q2 of Leetcode 
    /// https://leetcode.com/problems/add-two-numbers/
    /// 
    /// The idea is to get each incoming nodes at the same time add them and create a node for it,
    /// when the sum is >10 then we know that we carry one for next summation, and the current node should be Sum - 10 = giving 0, or 1, etc
    /// as 13-10 = 3 you carry one and leave the 3 as current, same for 10-10, still carries one and current node is 0
    /// 
    /// When the sum and carry are handled then is just linking the previous node to this one creating the linked list simultaneously
    /// Carefull as we want to give the head node and we constructing the list then just make a holder for the first sum result as that will be the head
    /// and the solution to our problem
    /// </summary>
    public class Implementation1 : IQ2Solution
    {
        public LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2)
        {
            // init variables
            LinkedListNode previousResultingNode = null;
            LinkedListNode resultingSumStartingNode = null;
            int carry = 0;
            int sum = 0;

            // traverse condition
            while (l1!=null | l2!=null | carry==1)
            {
                // handle different lenghts
                if (l1 == null) l1 = new LinkedListNode() { Value = 0 };
                if (l2 == null) l2 = new LinkedListNode() { Value = 0 };

                // perform addition
                sum = l1.Value + l2.Value + carry;

                // handle sum above 10
                if(sum > 9)
                {
                    sum -= 10;
                    carry = 1;
                }
                else 
                {
                    // reset carry
                    carry = 0;
                }

                // create resulting node
                LinkedListNode resultingNode = new() { Value = sum };

                // link previous node to this current one if there was a node before it
                if(previousResultingNode != null)
                {
                    previousResultingNode.Next = resultingNode;
                }
                else
                {
                    // if no node before it the this is the first put a marker on it to return later as we will move and lose this position
                    resultingSumStartingNode = resultingNode;
                }

                // move locations +1
                previousResultingNode = resultingNode;
                l1 = l1.Next;
                l2 = l2.Next;
            }
            return resultingSumStartingNode;
        }
    }
}
