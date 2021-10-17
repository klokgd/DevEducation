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
        public void CalcFormulaTest()
        {
            // подготовка
            int a = 5;
            int b = -5;
            double expected = -5;

            // действие
            double actual = _hw1.CalcFormula(a, b);

            // проверка
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MixVariablesTest()
        {
            // подготовка
            string a = "parampampam";
            string b = "чевапчичи";
            string expected = "чевапчичи";

            // действие
            string actual = _hw1.MixVariables(a, b);

            // проверка
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideTheNumbersTest()
        {
            // подготовка
            int a = 10;
            int b = 5;
            double expected = 2;

            // действие
            double actual = _hw1.DivideTheNumbers(a, b);

            // проверка
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetTheRemainderOfTheDivisionTest()
        {
            // подготовка
            int a = 10;
            int b = 5;
            double expected = 0;

            // действие
            double actual = _hw1.GetTheRemainderOfTheDivision(a, b);

            // проверка
            Assert.AreEqual(expected, actual);
        } 
        [Test]
        public void FindXOfTheLinearEquationTest()
        {
            // подготовка
            int a = 2;
            int b = 5;
            int c = 15;
            double expected = 5;

            // действие
            double actual = _hw1.FindXOfTheLinearEquation(a, b, c);

            // проверка
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FindAInTheStraightLineFormula()
        {
            // подготовка
            int x1 = 10;
            int y1 = 15;
            int x2 = 5;
            int y2 = 5;
            double expected = 2;

            // действие
            double actual = _hw1.FindAInTheStraightLineFormula(x1, y1, x2, y2); 

            // проверка
            Assert.AreEqual(expected, actual);
        } 
        [Test]
        public void FindBInTheStraightLineFormula()
        {
            // подготовка
          
            int x2 = 5;
            int y2 = 5;
            double a = 2;
            double expected = -5;

            // действие
            double actual = _hw1.FindBInTheStraightLineFormula(x2, y2, a);

            // проверка
            Assert.AreEqual(expected, actual);
        }
    }
}