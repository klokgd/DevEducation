using System;
using HomeWork1;
using HomeWork2;
using HomeWork3;
using HomeWork4;
using HomeWork5;
using Lists;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1 hw1 = new HW1();
            HW2 hw2 = new HW2();
            HW3 hw3 = new HW3();
            HW4 hw4 = new HW4();
            HW5 hw5 = new HW5();

            ArrayList first = new ArrayList(new int[] { 1, 6, 3, 2, 0, 7, 8 });
            LinkedList second = new LinkedList(new int[] { 1, 3, 0, 666, 5, 2 });

            Console.WriteLine(  second.IndexOfMin());
            Console.WriteLine();


            foreach (var item in second.ToArray())
            {
                Console.WriteLine(item);

            }



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
                    case 3:
                        switch (numberTask)
                        {
                            case 1:
                                hw3.SolveTask1();
                                break;
                            case 2:
                                hw3.SolveTask2();
                                break;
                            case 3:
                                hw3.SolveTask3();
                                break;
                            case 4:
                                hw3.SolveTask4();
                                break;
                            case 5:
                                hw3.SolveTask5();
                                break;
                            case 6:
                                hw3.SolveTask6();
                                break;
                            case 7:
                                hw3.SolveTask7();
                                break;
                            case 8:
                                hw3.SolveTask8();
                                break;
                            case 9:
                                hw3.SolveTask9();
                                break;
                            case 10:
                                hw3.SolveTask10();
                                break;
                            case 11:
                                hw3.SolveTask11();
                                break;
                            case 12:
                                hw3.SolveTask12();
                                break;
                            default:
                                test = false;
                                break;
                        }
                        break;
                    case 4:
                        switch (numberTask)
                        {
                            case 1:
                                hw4.SolveTask1();
                                break;
                            case 2:
                                hw4.SolveTask2();
                                break;
                            case 3:
                                hw4.SolveTask3();
                                break;
                            case 4:
                                hw4.SolveTask4();
                                break;
                            case 5:
                                hw4.SolveTask5();
                                break;
                            case 6:
                                hw4.SolveTask6();
                                break;
                            case 7:
                                hw4.SolveTask7();
                                break;
                            case 8:
                                hw4.SolveTask8();
                                break;
                            case 9:
                                hw4.SolveTask9();
                                break;
                            case 10:
                                hw4.SolveTask10();
                                break;
                            default:
                                test = false;
                                break;
                        }
                        break;
                    case 5:
                        switch (numberTask)
                        {
                            case 1:
                                hw5.SolveTask1();
                                break;
                            case 2:
                                hw5.SolveTask2();
                                break;
                            case 3:
                                hw5.SolveTask3();
                                break;
                            case 4:
                                hw5.SolveTask4();
                                break;
                            case 5:
                                hw5.SolveTask5();
                                break;
                            case 6:
                                hw5.SolveTask6();
                                break;
                            default:
                                test = false;
                                break;
                        }
                        break;
                    default:
                        break;
                }



            }

        }

    }
}
