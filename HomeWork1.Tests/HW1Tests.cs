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
            // ����������
            int a = 5;
            int b = -5;
            double expected = -5;

            // ��������
            double actual = _hw1.CalcFormula(a, b);

            // ��������
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MixVariablesTest()
        {
            // ����������
            string a = "parampampam";
            string b = "���������";
            string expected = "���������";

            // ��������
            string actual = _hw1.MixVariables(a, b);

            // ��������
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideTheNumbersTest()
        {
            // ����������
            int a = 10;
            int b = 5;
            double expected = 2;

            // ��������
            double actual = _hw1.DivideTheNumbers(a, b);

            // ��������
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetTheRemainderOfTheDivisionTest()
        {
            // ����������
            int a = 10;
            int b = 5;
            double expected = 0;

            // ��������
            double actual = _hw1.GetTheRemainderOfTheDivision(a, b);

            // ��������
            Assert.AreEqual(expected, actual);
        } 
        [Test]
        public void FindXOfTheLinearEquationTest()
        {
            // ����������
            int a = 2;
            int b = 5;
            int c = 15;
            double expected = 5;

            // ��������
            double actual = _hw1.FindXOfTheLinearEquation(a, b, c);

            // ��������
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FindAInTheStraightLineFormula()
        {
            // ����������
            int x1 = 10;
            int y1 = 15;
            int x2 = 5;
            int y2 = 5;
            double expected = 2;

            // ��������
            double actual = _hw1.FindAInTheStraightLineFormula(x1, y1, x2, y2); 

            // ��������
            Assert.AreEqual(expected, actual);
        } 
        [Test]
        public void FindBInTheStraightLineFormula()
        {
            // ����������
          
            int x2 = 5;
            int y2 = 5;
            double a = 2;
            double expected = -5;

            // ��������
            double actual = _hw1.FindBInTheStraightLineFormula(x2, y2, a);

            // ��������
            Assert.AreEqual(expected, actual);
        }
    }
}