using System;

namespace Helpers
{
    public class Class1
    {
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
