using NUnit.Framework;
using DataStructures.Searching.BinarySearch;


namespace UnitTests.BinarySearchTests
{
    public class BinarySearchShould
    {
        private IBinarySearchSolution _sut;

        [SetUp]
        public void Setup()
        {
            // set up some test data
            _sut = new BinarySearch();
        }

        [Test]
        [TestCase(1, new int[] {1,2,3,4}, 0)]
        [TestCase(-2, new int[] {-100,-2,3,47}, 1)]
        [TestCase(4, new int[] {1,4,6,8,9,77,94}, 6)]
        [TestCase(1, new int[] {1}, 0)]
        public void ReturnCorrect_Index_IfExists(int target, int[] sortedArray, int expected)
        {
            double result = _sut.Solution(target,sortedArray);
            Assert.AreEqual(expected,result);
        }

    }
}
