using DataStructures.LinkedList.Implementations;

namespace DataStructures.LinkedList
{
    /// <summary>
    /// The idea of this class is to be able to switch implementations easily just by inheriting
    /// a different implementation.
    /// The unit test will call this class so you don't have to make unit test for your own 
    /// just swap your own classes to inherit from and run the tests
    /// </summary>
    /// <typeparam name="LinkedListNode"></typeparam>
    public class SinglyLinkedList : Implementation1
    {
    }
}
