namespace DataStructures.Searching.BinarySearch
{
    /// <summary>
    /// Interface for binary search implementations
    /// </summary>
    public interface IBinarySearchSolution
    {
        /// <summary>
        /// Method to search the index of a number in a sorted array
        /// </summary>
        /// <returns>
        /// -1 if not found and its index within array if found
        /// </returns>
        int Solution(int target, int[] sortedList);
    }
}