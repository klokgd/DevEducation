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


        [TestCase(0, new int[] {2, 1})]
        [TestCase(1)]
        [TestCase(-1)]
        public void FindTheMinimumIndexInAnArrayTests(int arrayIndex, int[] expected)
        {
            // arrange
            int[,] arrayToTest = TestData.FindTheMinimumIndexInAnArrayTest(arrayIndex);
            int[] actual = _hw5.FindTheMinimumIndexInAnArray(arrayToTest);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}