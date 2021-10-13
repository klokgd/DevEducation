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
    }
}
