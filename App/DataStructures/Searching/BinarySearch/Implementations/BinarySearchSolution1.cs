using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Searching.BinarySearch.Implementations
{
    /// <summary>
    /// Implementation 1 for binary search.
    /// </summary>
    public class BinarySearchSolution1
    {
        private int Middle(int[] array) => (int)Math.Ceiling(array.Length / 2f);
        private int _midIndex, _currentVal;

        public int Solution(int target, int[] sortedArray)
        {
            // IN: {2, [1,2,3]}
            while (true)
            {
                // return -1 if no more
                if (sortedArray == null) return -1; // [1,2,3]

                // take the middle
                _midIndex = Middle(sortedArray); // 1indx = 2 
                _currentVal = sortedArray[_midIndex];

                // compare to target
                if (_currentVal == target) return _midIndex; // skip

                // remove itself and whole corresponding side 
                if (_currentVal < target) // true
                {
                    sortedArray = PartitionArray(_midIndex++, sortedArray.Length, sortedArray); // [3]
                }
                else // false
                {
                    sortedArray = PartitionArray(0, _midIndex--, sortedArray);
                }
            }
        }        

        private int[] PartitionArray(int startIndex, int endIndex, int[] array)
        {
            try
            {
                return array.Skip((int)startIndex).Take((int)endIndex).ToArray();
            }
            catch
            {
                return null;
            }
        }
    }
}
