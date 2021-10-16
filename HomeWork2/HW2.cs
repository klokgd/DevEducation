using System;

namespace HomeWork2
{
    public class HW2
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число А: ");
            int b = GetNumberFromUser("Введите число B: ");
            int result = CountTheNumbersAfterTheConditions(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            int x = GetNumberFromUser("Введите координату X: ");
            int y = GetNumberFromUser("Введите координату Y: ");
            string result = FindTheCoordinateQuarter(x, y);
            Console.WriteLine(result);
        }
        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число А:  ");
            int b = GetNumberFromUser("Введите число B:  ");
            int c = GetNumberFromUser("Введите число C:  ");
            string result = PutNumbersInAscendingOrder(a, b, c);
            Console.WriteLine(result);
        }
        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число А:  ");
            int b = GetNumberFromUser("Введите число B:  ");
            int c = GetNumberFromUser("Введите число C:  ");
            double[] result = FindTheRootsOfTheQuadraticEquation(a, b, c);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите ваше число:  ");
            string result = TranslateTheNumberIntoText(a);
            Console.WriteLine(result);
            

        }
        

        private int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        private int CountTheNumbersAfterTheConditions(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            return result;

        }

        private string FindTheCoordinateQuarter(int x, int y)
        {
            string result = "";

            if ((x > 0) && (y > 0))
            {
                result = "Ваши переменные находятся в первой четверти";
            }
            else if ((x < 0) && (y > 0))
            {
                result = "Ваши переменные находятся в второй четверти";
            }
            else if ((x < 0) && (y < 0))
            {
                result = "Ваши переменные находятся в в третьей четверти";
            }
            else if ((x > 0) && (y < 0))
            {
                result = "Ваши переменные находятся в четвёртой четверти";
            }
            else if (x == 0)
            {
                result = "Ваши переменные находятся на координате Х";
            }
            else if (y == 0)
            {
                result = "Ваши переменные находятся на координате Y";
            }

            return result;
        }

        private string PutNumbersInAscendingOrder(int a, int b, int c)
        {
            int seniorNumber;
            int middleNumber;
            int juniorNumber;

            if ((a > b) & (a > c))
            {
                seniorNumber = a;
                if (b > c)
                {
                    middleNumber = b;
                    juniorNumber = c;
                }
                else
                {
                    middleNumber = c;
                    juniorNumber = b;
                }
            }
            else if ((b > a) & (b > c))
            {
                seniorNumber = b;
                if (a > c)
                {
                    middleNumber = a;
                    juniorNumber = c;
                }
                else
                {
                    middleNumber = c;
                    juniorNumber = a;
                }
            }
            else
            {
                seniorNumber = c;
                if (a > b)
                {
                    middleNumber = a;
                    juniorNumber = b;
                }
                else
                {
                    middleNumber = b;
                    juniorNumber = a;
                }
            }
            string result = $"Числа в порядке возрастания: {juniorNumber} {middleNumber} {seniorNumber} ";
            return result;
        }

        private double[] FindTheRootsOfTheQuadraticEquation(double a, double b, double c)
        {
            double d, x1, x2;


            d = Math.Pow(b, 2) - 4 * a * c;

            if (d > 0)
            {
                x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                double[] result = { x1, x2 };
                return result;
            }
            else if (d == 0)
            {

                x1 = -(b / (2 * a));
                double[] result = { x1 };
                return result;

            }
            else
            {
                double[] result = { };
                return result;
            }

        }

        private string TranslateTheNumberIntoText(int twoDigitNumber)
        {
            string tenNumberToLetter, oneNumberToLetter;

            if ((twoDigitNumber < 100) & (twoDigitNumber > 9))
            {
                if (twoDigitNumber < 20)
                {
                    switch (twoDigitNumber)
                    {

                        case 11:
                            tenNumberToLetter = "Одиннадцать";
                            break;
                        case 12:
                            tenNumberToLetter = "Двенадцать";
                            break;
                        case 13:
                            tenNumberToLetter = "Тринадцать";
                            break;
                        case 14:
                            tenNumberToLetter = "Четырнадцать";
                            break;
                        case 15:
                            tenNumberToLetter = "Пятнадцать";
                            break;
                        case 16:
                            tenNumberToLetter = "Шестнадцать";
                            break;
                        case 17:
                            tenNumberToLetter = "Семнадцать";
                            break;
                        case 18:
                            tenNumberToLetter = "Восемнадцать";
                            break;
                        case 19:
                            tenNumberToLetter = "Девятнадцать";
                            break;
                        default:
                            tenNumberToLetter = "Десять";
                            break;
                    }
                    return tenNumberToLetter;

                }
                else
                {
                    int leftSideOfNumber = twoDigitNumber / 10;
                    int rightSideOfNumber = twoDigitNumber % 10;
                    switch (leftSideOfNumber)
                    {
                        case 1:
                            tenNumberToLetter = "Десять";
                            break;
                        case 2:
                            tenNumberToLetter = "Двадцать";
                            break;
                        case 3:
                            tenNumberToLetter = "Тридцать";
                            break;
                        case 4:
                            tenNumberToLetter = "Сорок";
                            break;
                        case 5:
                            tenNumberToLetter = "Пятьдесят";
                            break;
                        case 6:
                            tenNumberToLetter = "Шестьдесят";
                            break;
                        case 7:
                            tenNumberToLetter = "Семьдесят";
                            break;
                        case 8:
                            tenNumberToLetter = "Восемьдесят";
                            break;
                        default:
                            tenNumberToLetter = "Девяносто";
                            break;
                    }

                    if (rightSideOfNumber > 0)
                    {
                        switch (rightSideOfNumber)
                        {
                            case 1:
                                oneNumberToLetter = "Один";
                                break;
                            case 2:
                                oneNumberToLetter = "Два";
                                break;
                            case 3:
                                oneNumberToLetter = "Три";
                                break;
                            case 4:
                                oneNumberToLetter = "Четыре";
                                break;
                            case 5:
                                oneNumberToLetter = "Пять";
                                break;
                            case 6:
                                oneNumberToLetter = "Шесть";
                                break;
                            case 7:
                                oneNumberToLetter = "Семь";
                                break;
                            case 8:
                                oneNumberToLetter = "Восемь";
                                break;
                            default:
                                oneNumberToLetter = "Девять";
                                break;
                        }

                        string result = $"Текст в число:\n{tenNumberToLetter} {oneNumberToLetter}";
                        return result;
                    }
                    else
                    {
                        string result = $"Текст в число:\n{tenNumberToLetter}";
                        return result;
                    }
                }
            }
            else
            {
                string result = "Ошибка! Нужно двухзначное число.";
                return result;

            }
        }



    }
}
