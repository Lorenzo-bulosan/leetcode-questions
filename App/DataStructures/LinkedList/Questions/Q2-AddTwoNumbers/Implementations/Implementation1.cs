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
    /// </summary>
    public class Implementation1 : IQ2Solution
    {
        public LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2)
        {
            // init variables
            LinkedListNode previousResultingNode = null;
            int carry = 0;
            int sum = 0;

            // traverse condition
            while (l1!=null | l2!=null | carry!=1)
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

                // link previous node to this current one
                if(previousResultingNode != null)
                {
                    previousResultingNode.Next = resultingNode;
                }               
            }
            return previousResultingNode;
        }
    }
}
