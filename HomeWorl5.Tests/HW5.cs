using NUnit.Framework;

namespace HomeWorl5.Tests
{
    public class HW5
    {
        private HW5 _hw5;

        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void FindTheMaximumIndexInAnArrayTests(int arrayIndex)
        {
            // arrange
            int[,] arrayToTest = TestData.FindTheMinimumNumberInAnArrayTest(arrayIndex);
            int[] expected = TestData.FindExpectedTheMinimumNumberInAnArrayTest(arrayIndex);

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}