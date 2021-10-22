using Lists;
using NUnit.Framework;

namespace List.Tests
{
    public class ALTests
    {
        private ArrayList _arrlist;

        [SetUp]
        public void Setup()
        {
            _arrlist = new ArrayList();
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4})]
        public void AddLastTests(int[] array, int value, int[] expected)
        {
            // arrange
            ArrayList arrayToTest = new ArrayList(array);
            arrayToTest.UpSize();
            arrayToTest.AddLast(value);
            int[] actual = arrayToTest.ToArray();

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}