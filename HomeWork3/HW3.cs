using System;

namespace HomeWork3
{
    public class HW3
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число: ");
            int b = GetNumberFromUser("Введите степень: ");
            int result = Exponentiation(a, b);
            Console.WriteLine($"Результат: {result}");
        }
        public void SolveTask2()
        {
            int a = GetNumberFromUser("Введите число: ");
            int[] result = PrintNumbersThatAreDivisibleByANumber(a);
            foreach (var item in result)
            {
                Console.WriteLine($"Ваше число: {item}");
            }
        }
        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число: ");
            int result = FindNumbersLessThanSquared(a);
            Console.WriteLine($"Количество необходимых чисел: {result}");
        }
        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число: ");
            int result = FindTheGreatestDivisor(a);
            Console.WriteLine($"Наибольший делитель этого числа: {result}");
        }
        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите первое число: ");
            int b = GetNumberFromUser("Введите второе число: ");
            int result = FindNumbersDivisibleBy7(a, b);
            Console.WriteLine($"Сумма всех найденных чисел: {result}");
        }
        public void SolveTask6()
        {
            int a = GetNumberFromUser("Введите ряд чисел фибоначчи:");
            int[] result = PrintASeriesOfFibonacciNumbers(a);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public void SolveTask7()
        {
            Console.WriteLine("Ищем наибольший общий делитель для двух чисел");
            int a = GetNumberFromUser("Введите первое число: ");
            int b = GetNumberFromUser("Введите второе число:");
            int result = LookingForACommonDivisorOfTwoNumbers(a, b);
            Console.WriteLine($"Наибольший общий делитель {result}");


        }
        public void SolveTask8()
        {
            int a = GetNumberFromUser("Введите целое положительное число, которое является кубом числа N: ");
            int result = SearchNumberCube(a);
            Console.WriteLine($"Вот число, которое возвели в куб: {result}");


        }
        public void SolveTask9()
        {
            int a = GetNumberFromUser("Введите ваше число: ");
            int result = FindTheNumberOfOddDigitsInANumber(a);
            Console.WriteLine($"Количество нечетных цифр: {result}");


        }
        public void SolveTask10()
        {
            int a = GetNumberFromUser("Введите ваше число: ");
            int result = FlipTheNumber(a);
            Console.WriteLine($"Официально отзеркалили ваше число: {result}");


        }
        public void SolveTask11()
        {
            int a = GetNumberFromUser("Введите ваше число: ");
            int result = DisplaySeriesNumbersSumOddMore(a);
            Console.WriteLine(result);

        }
        public void SolveTask12()
        {
            int a = GetNumberFromUser("Введите первое число: ");
            int b = GetNumberFromUser("Введите второе число: ");
            string result = FindIdenticalNumbersInAPair(a, b);
            Console.WriteLine($"{result}");


        }
        private int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        private int Exponentiation(int a, int b)
        {
            int intermediate;
            int result = a;

            for (int index = 1; index < b; index++)
            {
                intermediate = a;
                result *= intermediate;
            };

            return result;

        }
        private int[] PrintNumbersThatAreDivisibleByANumber(int a)
        {
            int length = 0;
            for (int index = 0; index <= 1000; index++)
            {
                if (index % a == 0)
                {
                    length++;
                    Console.WriteLine($"Число {index} делится на число {a}");
                }
            }


            int[] result = new int[length];

            length = 0;

            for (int index = 0; index <= 1000; index++)
            {
                if (index % a == 0)
                {
                    result[length] = index;
                    length++;

                }
            }

            return result;
        }

        private int FindNumbersLessThanSquared(int a)
        {
            int result = 0;
            for (int index = 1; index < a; index++)
            {

                if (Math.Pow(index, 2) < a)
                {
                    Console.WriteLine($"Число {index} меньше числа {a} в квадрате");
                    result += 1;
                }
            };
            return result;
        }

        private int FindTheGreatestDivisor(int a)
        {
            int result = 0;
            for (int index = a - 1; index > 0; index--)
            {

                if (a % index == 0)
                {
                    result = index;
                    break;
                }
            };
            return result;
        }

        private int FindNumbersDivisibleBy7(int a, int b)
        {
            int equal = 0;

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        equal += i;
                        Console.WriteLine($"Число, которое делится без остатка: {i}");
                        Console.WriteLine($"Сумма на данный момент: {equal}");
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        equal += i;
                        Console.WriteLine($"Число, которое делится без остатка: {i}");
                        Console.WriteLine($"Сумма на данный момент: {equal}");
                    }
                }
            }

            return equal;
        }

        private int[] PrintASeriesOfFibonacciNumbers(int a)
        {
            int y = 1;
            int x = 1;
            int equal = 0;
            int[] result = new int[a];

            for (int i = 0; i < a; i++)
            {
                equal = x + y;
                x = y;
                y = equal;

                result[i] = y;
            }

            return result;

        }

        private int LookingForACommonDivisorOfTwoNumbers(int a, int b)
        {
            int temperlate = 1;
            int tempA = a;
            int tempB = b;
            int result = 0;
            do
            {
                if (a > b)
                {
                    temperlate = tempA % tempB;

                    if (temperlate == 0)
                    {
                        result = b;
                        break;
                    }

                    tempA = tempB;
                    tempB = temperlate;
                    temperlate = tempA % tempB;

                    if ((a % temperlate == 0) && (b % temperlate == 0))
                    {
                        result = temperlate;
                    }
                }
                else
                {
                    temperlate = tempB % tempA;

                    if (temperlate == 0)
                    {
                        result = a;
                        break;
                    }

                    tempB = tempA;
                    tempA = temperlate;
                    temperlate = tempB % tempA;

                    if ((a % temperlate == 0) && (b % temperlate == 0))
                    {
                        result = temperlate;
                    }
                }
            }
            while ((a % temperlate != 0) || (b % temperlate != 0));
            return result;
        }

        private int SearchNumberCube(int a)
        {
            int right = a;
            int left = 0;
            int mid = a / 2;
            if (a == 0)
            {
                Console.WriteLine("Число A равно нулю");
            }
            else
            {
                while (mid * mid * mid != a)
                {
                    if (mid * mid * mid > a)
                    {
                        right = mid;
                        mid = (right + left) / 2;
                    }
                    else
                    {
                        left = mid;
                        mid = (right + left) / 2;
                    }
                }
            }
            return mid;
        }

        private int FindTheNumberOfOddDigitsInANumber(int a)
        {
            int numberOdd = 0;
            int testNumber = a;
            while (a > 0)
            {
                testNumber = a % 10;
                if (testNumber % 2 != 0)
                {
                    numberOdd += 1;
                }
                a = a / 10;

            }
            return numberOdd;
        }

        private int FlipTheNumber(int a)
        {
            int reverse = 0;
            int reverseTemp = 0;
            int testNumber = a;
            while (a > 0)
            {
                reverseTemp = reverse * 10;
                testNumber = a % 10;
                reverse = reverseTemp + testNumber;
                a = a / 10;
            }
            return reverse;
        }

        private int DisplaySeriesNumbersSumOddMore(int a)
        {
            int sumEven = 0;
            int sumOdd = 0;
            int temperlate = 0;
            int temperlate2 = 0;
            for (int i = 1; i <= a; i++)
            {
                if (i < 10)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);

                    }

                }
                else
                {
                    temperlate2 = i;
                    while (temperlate2 != 0)
                    {
                        temperlate = temperlate2 % 10;

                        if (temperlate % 2 == 0)
                        {
                            sumEven = sumEven + temperlate;
                        }
                        else
                        {
                            sumOdd = sumOdd + temperlate;
                        }
                        temperlate2 = temperlate2 / 10; //я явно что-то усложнил в этой задаче


                    }
                    if (sumEven > sumOdd)
                    {
                        Console.WriteLine(i);
                        sumEven = 0;
                        sumOdd = 0;
                    }
                    else
                    {
                        sumEven = 0;
                        sumOdd = 0;
                    }


                }
            }
            return sumEven;
        }

        private string FindIdenticalNumbersInAPair(int a, int b)
        {
            int partA;
            int partB;
            int bruteB = b;
            string result = "";
            while (a > 0)
            {
                partA = a % 10;
                a = a / 10;
                partB = b;
                while (partB > 0)
                {

                    if (partB % 10 == partA)
                    {
                        result = "ДА!";
                        break;
                    }
                    partB = partB / 10;
                }


            }
            return result;
        }
    }
}

