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
            string mix1 = MixVariables(a, b);
            string mix2 = MixVariables(b, a);
            Console.WriteLine("Теперь A - " + mix1 + ", а B - это " + mix2);

        }
        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число А: ");
            int b = GetNumberFromUser("Введите число B: ");
            double divisionResult = DivideTheNumbers(a, b);
            double integerRemainder = GetTheRemainderOfTheDivision(a, b);
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



        private int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        private string GetTextFromUser(string message)
        {
            Console.WriteLine(message);
            string text = Console.ReadLine();
            return text;
        }

        private double CalcFormula(int a, int b)
        {
            double calculationResult = ((5 * a) + Math.Pow(b, 2)) / (b - a);
            return calculationResult;
        }

        private double DivideTheNumbers(int a, int b)
        {
            double calculationResult = a / b;
            return calculationResult;
        }
        private double GetTheRemainderOfTheDivision(int a, int b)
        {
            double calculationResult = a % b;
            return calculationResult;
        }
        private double FindXOfTheLinearEquation(int a, int b, int c)
        {
            double x = (c - b) / a;
            return x;
        }
        private double FindAInTheStraightLineFormula(int x1, int y1, int x2, int y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            return a;
        }
        private double FindBInTheStraightLineFormula(int x2, int y2, double a)
        {
            double b = y2 - a * x2;
            return b;
        }

        private string MixVariables(string a, string b)
        {
            a = b;
            return a;
        }


    }
}
