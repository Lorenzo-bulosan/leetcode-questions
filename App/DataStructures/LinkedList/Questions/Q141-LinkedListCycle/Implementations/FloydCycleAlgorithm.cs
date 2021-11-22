using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Questions.Q141_LinkedListCycle.Implementations
{
    /// <summary>
    /// Implementation of Q141
    /// https://leetcode.com/problems/linked-list-cycle/
    /// 
    /// Overview of solution:
    /// We are going to solve this using Floyds Algorithm to detect cycles
    /// </summary>
    public class FloydCycleAlgorithm : IQ141Solution
    {
        public bool Solution(LinkedListNode head)
        {
            // edge case: empty list
            if (head == null) return false;

            // init pointers
            LinkedListNode pos1 = head;
            LinkedListNode pos2 = head;
            
            // traverse condtion
            while (pos2 != null) // means end of list i.e no cycle
            {
                // update position at different speeds
                pos1 = pos1.Next;
                pos2 = pos2.Next.Next;

                // when fast pointer catches up with slow means cycle
                if (pos1 == pos2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
