using System;

namespace HomeWork1
{
    public class HW1
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число А: ");
            int b = GetNumberFromUser("Введите число B: ");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public void SolveTask2()
        {
            string a = GetTextFromUser("Введите текст А: ");
            string b = GetTextFromUser("Введите текст В: ");
            MixVariables(ref a, b);
            Console.WriteLine("Теперь A - " + a + ", а B - это " + b);

        }
        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число А: ");
            int b = GetNumberFromUser("Введите число B: ");
            double divisionResult = DivideTheNumbers(a, b);
            int integerRemainder = GetTheRemainderOfTheDivision(a, b);
            Console.WriteLine("Результат деления чисел: " + divisionResult);
            Console.WriteLine("Остаток от деления: " + integerRemainder);
        }
        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число А: ");
            int b = GetNumberFromUser("Введите число B: ");
            int c = GetNumberFromUser("Введите число C: ");
            double x = FindXOfTheLinearEquation(a, b, c);
            Console.WriteLine("X равен: " + x);
        }
        public void SolveTask5()
        {
            int x1 = GetNumberFromUser("Введите число X1: ");
            int y1 = GetNumberFromUser("Введите число Y1: ");
            int x2 = GetNumberFromUser("Введите число X2: ");
            int y2 = GetNumberFromUser("Введите число Y2: ");
            double a = FindAInTheStraightLineFormula(x1, y1, x2, y2);
            double b = FindBInTheStraightLineFormula(x2, y2, a);
            Console.WriteLine($"Уравнение прямой: Y = {a}X + {b}");
        }



        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string GetTextFromUser(string message)
        {
            Console.WriteLine(message);
            string text = Console.ReadLine();
            return text;
        }

        public double CalcFormula(int a, int b)
        {
            if (a == b)
            {
                throw new ArgumentException("Значения А и В должны быть разными");
            }
            double calculationResult = ((5 * a) + Math.Pow(b, 2)) / (b - a);
            return calculationResult;
        }

        public double DivideTheNumbers(int a, int b)
        {
            double calculationResult = a / b;
            return calculationResult;
        }
        public int GetTheRemainderOfTheDivision(int a, int b)
        {
            int calculationResult = a % b;
            return calculationResult;
        }
        public double FindXOfTheLinearEquation(int a, int b, int c)
        {
            double x = (c - b) / a;
            return x;
        }
        public double FindAInTheStraightLineFormula(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                throw new ArgumentException("Значения X1 и X2 должны быть разными");
            }
            double a = (y1 - y2) / (x1 - x2);
            return a;
        }
        public double FindBInTheStraightLineFormula(int x2, int y2, double a)
        {
            double b = y2 - a * x2;
            return b;
        }

        public void MixVariables(ref string a, string b)
        {
            string x = a;
            a = b;
            b = x;
        }
        


    }
}
