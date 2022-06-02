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
        private double Middle(double[] array) => Math.Ceiling(array.Length / 2f);
        private double _midIndex;

        public double Solution(double target, double[] sortedArray)
        {
            // IN: {2, [1,2,3]}
            while (true)
            {
                // return -1 if no more
                if (sortedArray == null) return -1; // [1,2,3]

                // take the middle
                _midIndex = Middle(sortedArray); // 1indx = 2 

                // compare to target
                if (_midIndex == target) return _midIndex; // skip

                // remove itself and whole corresponding side 
                if (_midIndex > target) // true
                {
                    sortedArray = PartitionArray(_midIndex++, sortedArray.Length, sortedArray); // [3]
                }
                else // false
                {
                    sortedArray = PartitionArray(0, _midIndex--, sortedArray);
                }
            }
        }        

        private double[] PartitionArray(double startIndex, double endIndex, double[] array)
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
