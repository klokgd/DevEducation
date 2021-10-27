using HomeWork5;
using HomeWork5.Tests;
using NUnit.Framework;

namespace HomeWorl5.Tests
{
    public class HW5Tests
    {
        private HW5 _hw5;

        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();

        }


        [TestCase(0, -5)]
        [TestCase(1, 0)]
        public void FindTheMinimumNumberInAnArrayTests(int arrayIndex, int expected)
        {
            // arrange
            int[,] arrayToTest = TestData.FindTheMinimumNumberInAnArrayTest(arrayIndex);
            int actual = _hw5.FindTheMinimumNumberInAnArray(arrayToTest);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        } 
        [TestCase(0, 9)]
        [TestCase(1, 1)]
        public void FindTheMaximumNumberInAnArrayTests(int arrayIndex, int expected)
        {
            // arrange
            int[,] arrayToTest = TestData.FindTheMaximumNumberInAnArrayTest(arrayIndex);
            int actual = _hw5.FindTheMaximumNumberInAnArray(arrayToTest);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
        
        [TestCase(0, new int[] {2, 1})]
        [TestCase(1, new int[] { 2, 0 })]
        public void FindTheMinimumIndexInAnArrayTests(int arrayIndex, int[] expected)
        {
            // arrange
            int[,] arrayToTest = TestData.FindTheMinimumIndexInAnArrayTest(arrayIndex);
            int[] actual = _hw5.FindTheMinimumIndexInAnArray(arrayToTest);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(0, new int[] {3, 1})]
        [TestCase(1, new int[] { 0, 0 })]
        public void FindTheMaximumIndexInAnArrayTests(int arrayIndex, int[] expected)
        {
            // arrange
            int[,] arrayToTest = TestData.FindTheMaximumIndexInAnArrayTest(arrayIndex);
            int[] actual = _hw5.FindTheMaximumIndexInAnArray(arrayToTest);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        } 

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        public void FindFearOfNeighborsTests(int arrayIndex, int expected)
        {
            // arrange
            int[,] arrayToTest = TestData.FindFearOfNeighborsTest(arrayIndex);
            int actual = _hw5.FindFearOfNeighbors(arrayToTest);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(0)]
        [TestCase(1)]
        public void TransposeMatrixTests(int arrayIndex)
        {
            // arrange
            int[,] arrayToTest = TestData.TransposeMatrixTest(arrayIndex);
            _hw5.TransposeMatrix(arrayToTest);
            int[,] expected = TestData.TransposeMatrixExpect(arrayIndex);

            // act

            // assert
            Assert.AreEqual(expected, arrayToTest);

        }
    }
}