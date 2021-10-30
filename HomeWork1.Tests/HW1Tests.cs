using NUnit.Framework;
using System;

namespace HomeWork1.Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;

        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }

        [TestCase(5, -5, -5)]
        [TestCase(2, 3, 19)]
        public void CalcFormulaTests(int a, int b, double expected)
        {
            // arrange


            // act
            double actual = _hw1.CalcFormula(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(2, 2, 19)]
        public void CalcFormulaNegativeTests(int a, int b, double expected)
        {
            // arrange

            // act
            Assert.Throws(typeof(ArgumentException), () => _hw1.CalcFormula(a, b));

            // assert

        }
        
        [TestCase("parampampam", "чевапчичи")]

        public void SwapVariablesTests(string a, string b)
        {
            // arrange
          
            string expected = "чевапчичи";
            string expected2 = "parampampam";

            // act
            _hw1.SwapVariables(ref a, ref b);

            // assert
            Assert.AreEqual(expected, a);
        }
        
        [TestCase(10, 5, 2)]
        [TestCase(16, 8, 2)]
        [TestCase(9, 5, 1)]
        public void DivideTheNumbersTests(int a, int b, int expected)
        {
            // arrange
        
            // act
            int actual = _hw1.DivideTheNumbers(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, 5, 0)]
        [TestCase(10, 2, 0)]
        [TestCase(10, 3, 1)]

        public void GetTheRemainderOfTheDivisionTests(int a, int b, int expected)
        {
            // arrange
            
            // act
            int actual = _hw1.GetTheRemainderOfTheDivision(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 5, 10, 1)]
        [TestCase(2, 3, 9, 3)]
        public void FindXOfTheLinearEquationTests(int a, int b, int c, int expected)
        {
            // arrange
           
            // act
            double actual = _hw1.FindXOfTheLinearEquation(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 3, 9, 3)]
        public void FindXOfTheLinearEquationNegativeTests(int a, int b, int c, int expected)
        {
            // arrange

            // act
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.FindXOfTheLinearEquation(a, b, c));

            // assert
        }
        [TestCase(10, 15, 5, 5, 2)]
        [TestCase(30, 150, 5, 50, 4)]

        public void FindAInTheStraightLineFormulaTests(int x1, int y1, int x2, int y2, double expected)
        {
            // act
            double actual = _hw1.FindAInTheStraightLineFormula(x1, y1, x2, y2); 

            // assert
            Assert.AreEqual(expected, actual);
        } 
        [TestCase(30, 150, 30, 50, 4)]

        public void FindAInTheStraightLineFormulaNegativeTests(int x1, int y1, int x2, int y2, double expected)
        {
            // act
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.FindAInTheStraightLineFormula(x1, y1, x2, y2));

        }
        [TestCase(5, 5, 2, -5)]
        [TestCase(2, 100, 15, 70)]
        public void FindBInTheStraightLineFormulaTests(int x2, int y2, double a, double expected)
        {
            // arrange
          
            // act
            double actual = _hw1.FindBInTheStraightLineFormula(x2, y2, a);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}