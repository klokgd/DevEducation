using NUnit.Framework;

namespace HomeWork2.Tests
{
    public class Tests
    {
        private HW2 _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        [TestCase(10, 5, 15)]
        [TestCase(1, 5, -4)]
        [TestCase(5, 5, 25)]
        public void CountTheNumbersAfterTheConditionsTests(int a, int b, double expected)
        {
            // arrange


            // act
            double actual = _hw2.CountTheNumbersAfterTheConditions(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(10, 5, 1)]
        [TestCase(0, 5, 5)]
        [TestCase(5, 0, 6)]
        [TestCase(-5, 10, 2)]
        [TestCase(5, -10, 4)]
        [TestCase(-5, -10, 3)]

        public void FindTheCoordinateQuarterTests(int x, int y, string expected)
        {
            // arrange


            // act
            int actual = _hw2.FindTheCoordinateQuarter(x, y);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(-5, 20, 10, "����� � ������� �����������: -5 10 20 ")]
        [TestCase(52, 20, 10, "����� � ������� �����������: 10 20 52 ")]
        [TestCase(0, 10, 20, "����� � ������� �����������: 0 10 20 ")]
        [TestCase(0, 10, 10, "����� � ������� �����������: 0 10 10 ")]
        [TestCase(10, 10, 10, "����� � ������� �����������: 10 10 10 ")]


        public void PutNumbersInAscendingOrderTests(int a, int b, int c, string expected)
        {
            // arrange


            // act
            string actual = _hw2.PutNumbersInAscendingOrder(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, -8, 12, new double[] {6, 2})]
        [TestCase(1, -8, 16, new double[] {4})]
        [TestCase(5, 3, 7, new double[] {})]
      
        
        public void FindTheRootsOfTheQuadraticEquationTests(int a, int b, int c, double[] expected)
        {
            // arrange


            // act
            double[] actual = _hw2.FindTheRootsOfTheQuadraticEquation(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, "����� � �����:\n������")]
        [TestCase(23, "����� � �����:\n�������� ���")]
        [TestCase(50, "����� � �����:\n���������")]
        [TestCase(15, "����� � �����:\n����������")]
        [TestCase(105, "������! ����� ����������� �����.")]
        [TestCase(0, "������! ����� ����������� �����.")]
      
        
        public void TranslateTheNumberIntoTextTests(int a, string expected)
        {
            // arrange


            // act
            string actual = _hw2.TranslateTheNumberIntoText(a);

            // assert
            Assert.AreEqual(expected, actual);

        }

    }
}