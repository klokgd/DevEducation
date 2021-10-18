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
        public void CountTheNumbersAfterTheConditionsTest(int a, int b, double expected)
        {
            // arrange


            // act
            double actual = _hw2.CountTheNumbersAfterTheConditions(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(10, 5, "Ваши переменные находятся в первой четверти")]
        [TestCase(0, 5, "Ваши переменные находятся на координате Х")]
        [TestCase(5, 0, "Ваши переменные находятся на координате Y")]
        [TestCase(-5, 10, "Ваши переменные находятся в второй четверти")]
        [TestCase(5, -10, "Ваши переменные находятся в четвёртой четверти")]
        [TestCase(-5, -10, "Ваши переменные находятся в в третьей четверти")]

        public void FindTheCoordinateQuarterTest(int x, int y, string expected)
        {
            // arrange


            // act
            string actual = _hw2.FindTheCoordinateQuarter(x, y);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(-5, 20, 10, "Числа в порядке возрастания: -5 10 20 ")]
        [TestCase(52, 20, 10, "Числа в порядке возрастания: 10 20 52 ")]
        [TestCase(0, 10, 20, "Числа в порядке возрастания: 0 10 20 ")]
        [TestCase(0, 10, 10, "Числа в порядке возрастания: 0 10 10 ")]
        [TestCase(10, 10, 10, "Числа в порядке возрастания: 10 10 10 ")]


        public void PutNumbersInAscendingOrderTest(int a, int b, int c, string expected)
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
      
        
        public void FindTheRootsOfTheQuadraticEquationTest(int a, int b, int c, double[] expected)
        {
            // arrange


            // act
            double[] actual = _hw2.FindTheRootsOfTheQuadraticEquation(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, "Текст в число:\nДесять")]
        [TestCase(23, "Текст в число:\nДвадцать Три")]
        [TestCase(50, "Текст в число:\nПятьдесят")]
        [TestCase(15, "Текст в число:\nПятнадцать")]
        [TestCase(105, "Ошибка! Нужно двухзначное число.")]
        [TestCase(0, "Ошибка! Нужно двухзначное число.")]
      
        
        public void TranslateTheNumberIntoTextTest(int a, string expected)
        {
            // arrange


            // act
            string actual = _hw2.TranslateTheNumberIntoText(a);

            // assert
            Assert.AreEqual(expected, actual);

        }

    }
}