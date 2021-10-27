using NUnit.Framework;

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

        [Test]
        public void CalcFormulaTests()
        {
            // arrange
            int a = 5;
            int b = -5;
            double expected = -5;

            // act
            double actual = _hw1.CalcFormula(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MixVariablesTests()
        {
            // arrange
            string a = "parampampam";
            string b = "чевапчичи";
            string expected = "чевапчичи";

            // act
            _hw1.MixVariables(ref a, b);

            // assert
            Assert.AreEqual(expected, a);
        }
        [Test]
        public void DivideTheNumbersTests()
        {
            // arrange
            int a = 10;
            int b = 5;
            double expected = 2;

            // act
            double actual = _hw1.DivideTheNumbers(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetTheRemainderOfTheDivisionTests()
        {
            // arrange
            int a = 10;
            int b = 5;
            double expected = 0;

            // act
            int actual = _hw1.GetTheRemainderOfTheDivision(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        } 
        [Test]
        public void FindXOfTheLinearEquationTests()
        {
            // arrange
            int a = 2;
            int b = 5;
            int c = 15;
            double expected = 5;

            // act
            double actual = _hw1.FindXOfTheLinearEquation(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FindAInTheStraightLineFormulaTests()
        {
            // arrange
            int x1 = 10;
            int y1 = 15;
            int x2 = 5;
            int y2 = 5;
            double expected = 2;

            // act
            double actual = _hw1.FindAInTheStraightLineFormula(x1, y1, x2, y2); 

            // assert
            Assert.AreEqual(expected, actual);
        } 
        [Test]
        public void FindBInTheStraightLineFormulaTests()
        {
            // arrange
          
            int x2 = 5;
            int y2 = 5;
            double a = 2;
            double expected = -5;

            // act
            double actual = _hw1.FindBInTheStraightLineFormula(x2, y2, a);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}