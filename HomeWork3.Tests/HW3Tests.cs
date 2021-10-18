using NUnit.Framework;

namespace HomeWork3.Tests
{
    public class HW3Tests

    {
        private HW3 _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();

        }

        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(-1, 3, -1)]
        public void ExponentiationTests(int a, int b, int expected)
        {
            // arrange


            // act
            double actual = _hw3.Exponentiation(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        } 
        [TestCase(200, new int[] { 0, 200, 400, 600, 800, 1000 })]
        [TestCase(500, new int[] { 0, 500, 1000 })]
        public void PrintNumbersThatAreDivisibleByANumberTests(int a, int[] expected)
        {
            // arrange


            // act
            int[] actual = _hw3.PrintNumbersThatAreDivisibleByANumber(a);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(27, 5)]
        [TestCase(40, 6)]
        [TestCase(1, 0)]
        [TestCase(100, 9)]
        public void FindNumbersLessThanSquaredTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FindNumbersLessThanSquared(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(100, 50)]
        [TestCase(70, 35)]
        [TestCase(10, 5)]
        [TestCase(15, 5)]
        public void FindTheGreatestDivisorTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FindTheGreatestDivisor(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(50, 100, 539)]
        [TestCase(100, 50, 539)]
        [TestCase(-10, 20, 14)]
        [TestCase(-30, 20, -49)]
        public void FindNumbersDivisibleBy7Tests(int a, int b, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FindNumbersDivisibleBy7(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }  
        [TestCase(6, new int[] { 2, 3, 5, 8, 13, 21})]
        public void PrintASeriesOfFibonacciNumbersTests(int a, int[] expected)
        {
            // arrange


            // act
            int[] actual = _hw3.PrintASeriesOfFibonacciNumbers(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(27, 8, 1)]
        [TestCase(25, 5, 5)]
        [TestCase(30, 20, 10)]
        public void LookingForACommonDivisorOfTwoNumbersTests(int a, int b, int expected)
        {
            // arrange


            // act
            int actual = _hw3.LookingForACommonDivisorOfTwoNumbers(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(27, 3)]
        [TestCase(125, 5)]
        [TestCase(729, 9)]
        public void SearchNumberCubeTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.SearchNumberCube(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(9, 1)]
        [TestCase(17, 2)]
        [TestCase(5225, 2)]
        [TestCase(175, 3)]
        public void FindTheNumberOfOddDigitsInANumberTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FindTheNumberOfOddDigitsInANumber(a);

            // assert
            Assert.AreEqual(expected, actual);

        } 
        [TestCase(175, 571)]
        [TestCase(303, 303)]
        [TestCase(100, 1)]
        [TestCase(1008, 8001)]
        public void FlipTheNumberTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FlipTheNumber(a);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(20, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20 })]
        [TestCase(40, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21,22, 24, 26, 28, 34, 36, 38, 40 })]
        public void DisplaySeriesNumbersSumOddMoreTests(int a, int[] expected)
        {
            // arrange


            // act
            int[] actual = _hw3.DisplaySeriesNumbersSumOddMore(a);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(175, 571, "дю!")]
        [TestCase(175, 300, "мер")]
        [TestCase(175, 100, "дю!")]
        [TestCase(175, 444, "мер")]

        public void FindIdenticalNumbersInAPairTests(int a, int b, string expected)
        {
            string actual = _hw3.FindIdenticalNumbersInAPair(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}