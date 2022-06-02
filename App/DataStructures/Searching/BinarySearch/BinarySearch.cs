using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructures.Searching.BinarySearch.Implementations;

namespace DataStructures.Searching.BinarySearch
{
    /// <summary>
    /// Implementing Binary Search
    /// 
    /// The idea of this class is to be able to switch implementations easily just by inheriting
    /// a different implementation.
    /// The unit test will call this class so you don't have to make unit test for your own 
    /// just swap your own classes to inherit from and run the tests
    /// </summary>
    public class BinarySearch : BinarySearchSolution1, IBinarySearchSolution
    {
        // DO NOT write the interface implementation here but on your solution1, solution2 etc 
    }
}
