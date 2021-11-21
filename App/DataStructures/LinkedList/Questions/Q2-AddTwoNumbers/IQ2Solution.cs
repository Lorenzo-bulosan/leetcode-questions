using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Questions.Q2_AddTwoNumbers
{
    /// <summary>
    /// Defines the solution structure for Q2 Leedcode
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public interface IQ2Solution
    {
        /// <summary>
        /// Method that provides the solution for the question above, return the final value as the head of the resulting linked list
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2);
    }
}
