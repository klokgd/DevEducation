using System;
using HomeWork1;
using HomeWork2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1 hw1 = new HW1();
            HW2 hw2 = new HW2();
       
            bool test = true;
       
            while (test)
            {
                Console.WriteLine();
                Console.WriteLine("Введите номер домашней работы:");
                int numberHomeWork = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер задания:");
                int numberTask = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Для прекращения поставьте 0\n");

                switch (numberHomeWork)
                {
                    case 1:
                        switch (numberTask)
                        {
                            case 1:
                                hw1.SolveTask1();
                                break;
                            case 2:
                                hw1.SolveTask2();
                                break;
                            case 3:
                                hw1.SolveTask3();
                                break;
                            case 4:
                                hw1.SolveTask4();
                                break;
                            case 5:
                                hw1.SolveTask5();
                                break;
                            default:
                                test = false;
                                break;
                        }
                        break;
                    case 2:
                        switch (numberTask)
                        {
                            case 1:
                                hw2.SolveTask1();
                                break;
                            case 2:
                                hw2.SolveTask2();
                                break;
                            case 3:
                                hw2.SolveTask3();
                                break;
                            case 4:
                                hw2.SolveTask4();
                                break;
                            case 5:
                                hw2.SolveTask5();
                                break;
                            default:
                                test = false;
                                break;
                        }
                        break;
                }


                
            }

        }

    }
}
