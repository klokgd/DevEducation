using NUnit.Framework;

namespace HomeWork4.Tests
{
    public class HW4Test
    {
        private HW4 _hw4;

        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();

        }

        [TestCase(new int[] { 0, 500, 1000 }, 0)]
        [TestCase(new int[] { 300, 2, 1000 }, 2)]
        [TestCase(new int[] { 300, 2, 1000, 0 }, 0)]
        [TestCase(new int[] { 300, 2, -1000, 0 }, -1000)]
        public void PrintNumbersThatAreDivisibleByANumberTests(int[] a, int expected)
        {
            // arrange


            // act
            int actual = _hw4.FindTheMinimumNumberInAnArray(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 0, 500, 1000 }, 1000)]
        [TestCase(new int[] { 300, 2, 1000 }, 1000)]
        [TestCase(new int[] { 300, 2, 0, 400 }, 400)]
        [TestCase(new int[] { 300, 2, -1000, 0 }, 300)]
        public void FindTheMaximumNumberInAnArrayTests(int[] a, int expected)
        {
            // arrange


            // act
            int actual = _hw4.FindTheMaximumNumberInAnArray(a);
            
            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 0, 500, 1000 }, 0)]
        [TestCase(new int[] { 300, 2, 1000 }, 1)]
        [TestCase(new int[] { 300, 2, 0, 400 }, 2)]
        [TestCase(new int[] { 300, 2, -1000, 0 }, 2)]
        public void FindTheMinimumIndexInAnArrayTests(int[] a, int expected)
        {
            // arrange


            // act
            int actual = _hw4.FindTheMinimumIndexInAnArray(a);

            // assert
            Assert.AreEqual(expected, actual);

        } 
        [TestCase(new int[] { 0, 500, 1000 }, 2)]
        [TestCase(new int[] { 300, 2, 1000 }, 2)]
        [TestCase(new int[] { 300, 2, 0, 400 }, 3)]
        [TestCase(new int[] { 300, 2, -1000, 0 }, 0)]
        [TestCase(new int[] { 300, 2, -1000, 0, 500, 666 }, 5)]
        public void FindTheMaximumIndexInAnArrayTests(int[] a, int expected)
        {
            // arrange


            // act
            int actual = _hw4.FindTheMaximumIndexInAnArray(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 0, 500, 1000 }, 500)]
        [TestCase(new int[] { 300, 2, 1000 }, 2)]
        [TestCase(new int[] { 300, 2, 0, 400 }, 402)]
        [TestCase(new int[] { 0, 300, 2, -1000, 0 }, -700)]
        [TestCase(new int[] { 300, 2, -1000, 0, 500, 666 }, 668)]
        public void CalculateTheSumOddIndicesTests(int[] a, int expected)
        {
            // arrange


            // act
            int actual = _hw4.CalculateTheSumOddIndices(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] {4, 3, 2, 1 })]
        public void FlipArrayTests(int[] a, int[] expected)
        {
            // arrange


            // act
            _hw4.FlipArray(a);

            // assert
            Assert.AreEqual(expected, a);

        }
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 5 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 5, 5 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 5, 6, 3 }, 4)]
        public void CountTheNumberOfOddElementsTests(int[] a, int expected)
        {
            // arrange


            // act
            int actual = _hw4.CountTheNumberOfOddElements(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        public void SwapPartsTests(int[] a, int[] expected)
        {
            // arrange


            // act
            _hw4.SwapParts(a);

            // assert
            Assert.AreEqual(expected, a);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 7, 2, 9, 4, 5, 1 }, new int[] { 1, 2, 4, 5, 7, 9 })]
        [TestCase(new int[] { 7, 2, 9, -4, 5, 1 }, new int[] {-4, 1, 2, 5, 7, 9 })]
        public void BubbleSortTests(int[] a, int[] expected)
        {
            // arrange


            // act
             _hw4.BubbleSort(a);

            // assert
            Assert.AreEqual(expected, a);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 7, 2, 9, 4, 5, 1 }, new int[] { 9, 7, 5, 4, 2, 1 })]
        [TestCase(new int[] { 7, 2, 9, -4, 5, 1 }, new int[] { 9, 7, 5, 2, 1, -4 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]
        public void InsertSortTests(int[] a, int[] expected)
        {
            // arrange


            // act
             _hw4.InsertSort(a);

            // assert
            Assert.AreEqual(expected, a);

        }
    }
}