using NUnit.Framework;
using System;

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
        public void RaiseNumberToPowerTests(int a, int b, int expected)
        {
            // arrange


            // act
            double actual = _hw3.RaiseNumberToPower(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(0, 3, -1)]
        [TestCase(3, 0, -1)]
        public void RaiseNumberToPowerNegativeTests(int a, int b, int expected)
        {
            // arrange


            // act
            Assert.Throws(typeof(ArgumentException), () => _hw3.RaiseNumberToPower(a, b));


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
        public void GetCountOfNumbersLessThanSquaredTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.GetCountOfNumbersLessThanSquared(a);

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
        public void FindSumNumbersDivisibleBy7Tests(int a, int b, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FindSumNumbersDivisibleBy7(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }  
        [TestCase(5, 13)]
        [TestCase(0, 1)]
        [TestCase(20, 17711)]
        public void PrintASeriesOfFibonacciNumbersTests(int a, int expected)
        {
            // arrange


            // act
            int actual = _hw3.FindNumberOfFibonacci(a);

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
        [TestCase(0, 20, 10)]
        [TestCase(20, 0, 10)]
        public void LookingForACommonDivisorOfTwoNumbersNegativeTests(int a, int b, int expected)
        {
            // arrange


            // act
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.LookingForACommonDivisorOfTwoNumbers(a, b));


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
        [TestCase(0, 9)]
        public void SearchNumberCubeNegativeTests(int a, int expected)
        {
            // arrange


            // act
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.SearchNumberCube(a));

            // assert

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

        [TestCase(175, 571, "ÄÀ!")]
        [TestCase(175, 300, "ÍÅÒ")]
        [TestCase(175, 100, "ÄÀ!")]
        [TestCase(175, 444, "ÍÅÒ")]
        [TestCase(104, 0, "ÄÀ!")]
        [TestCase(0, 104, "ÄÀ!")]
        [TestCase(0, 0, "ÄÀ!")]

        public void FindIdenticalNumbersInAPairTests(int a, int b, string expected)
        {
            string actual = _hw3.FindIdenticalNumbersInAPair(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}