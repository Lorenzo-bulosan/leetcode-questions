using DataStructures.LinkedList.Questions.Q206_ReverseLinkedList.Implementations;

namespace DataStructures.LinkedList.Questions.Q206_ReverseLinkedList
{
    /// <summary>
    /// Question206 from Leetcode https://leetcode.com/problems/reverse-linked-list/
    /// 
    /// The idea of this class is to be able to switch implementations easily just by inheriting
    /// a different implementation.
    /// The unit test will call this class so you don't have to make unit test for your own 
    /// just swap your own classes to inherit from and run the tests
    /// </summary>
    public class ReverseLinkedList : ReverseLinkedListSolution1 , IQ206Solution
    {

    }
}
