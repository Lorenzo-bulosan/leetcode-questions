using DataStructures.LinkedList.Questions.Q141_LinkedListCycle.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.Questions.Q141_LinkedListCycle
{
    /// <summary>
    /// Question Q141 from leetcode https://leetcode.com/problems/linked-list-cycle/
    /// 
    /// The idea of this class is to be able to switch implementations easily just by inheriting
    /// a different implementation.
    /// The unit test will call this class so you don't have to make unit test for your own 
    /// just swap your own classes to inherit from and run the tests
    /// </summary>
    public class LinkedListCycle : FloydCycleAlgorithm, IQ141Solution
    {
        
    }
}
