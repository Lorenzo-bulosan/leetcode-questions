using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Questions.Q2_AddTwoNumbers.Implementations
{
    public class AddTwoNumbersSolution2 : IQ2Solution
    {
        /*
        * l1 = [1,2] = 21
        * l2 = [0,0,3,2] = 250
        * result = [6,4] = 46
        */
        public LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2)
        {
            LinkedListNode currentNode1 = l1;
            int currentNode1Value = 0;
            LinkedListNode currentNode2 = l2;
            int currentNode2Value = 0;
            int multiplier = 1;
            int total = 0;

            // O(n+m) where n = length of linkedlist1, m = length of linkedlist2
            do
            {
                currentNode1Value = 0;
                currentNode2Value = 0;

                if (currentNode1 != null)
                {
                    currentNode1Value = currentNode1.Value;
                }

                if (currentNode2 != null)
                {
                    currentNode2Value = currentNode2.Value;
                }

                Console.WriteLine($"node1*multiplier:{currentNode1Value} * {multiplier} = { currentNode1Value*multiplier}");
                Console.WriteLine($"node2*multiplier:{currentNode2Value} * {multiplier} = { currentNode2Value*multiplier}");

                total += (currentNode1Value * multiplier) + (currentNode2Value * multiplier);       
                multiplier *= 10;

                Console.WriteLine($"Total = {total}");
                Console.WriteLine($"==============");

                if (currentNode1 != null)
                {
                    currentNode1 = currentNode1.Next;
                }

                if (currentNode2 != null)
                {
                    currentNode2 = currentNode2.Next;
                }


                if (currentNode1 == null && currentNode2 == null)
                    break;

            }
            while (true);


            // 1203 = [3,0,2,1]

            SinglyLinkedList result = new SinglyLinkedList();

            while (total > 0)
            {
                int value = total % 10; 
                total -= value;
                total /= 10;

                result.Append(value);
            }

            return result.HeadNode; // 2,4,9   5,9  -> 95 + 942 = 1037 -> 7,3,0,1
        }
    }
}
