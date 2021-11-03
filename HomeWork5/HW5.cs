using System;

namespace HomeWork5
{
    public class HW5
    {

        public void SolveTask1()
        {
            int[,] array = AddRandomInArray(6, 6);

            int result = FindTheMinimumNumberInAnArray(array);

            Console.WriteLine($"Минимальное число в массиве: {result}");
        }
        public void SolveTask2()
        {
            int[,] array = AddRandomInArray(6, 6);

            int result = FindTheMaximumNumberInAnArray(array);

            Console.WriteLine($"Максимальное число в массиве: {result}");
        }
        public void SolveTask3()
        {
            int[,] array = AddRandomInArray(6, 6);

            int[] result = FindTheMinimumIndexInAnArray(array);
            Console.WriteLine($"Индекс минимального числа: {result[0]} {result[1]}");

        }
        public void SolveTask4()
        {
            int[,] array = AddRandomInArray(6, 6);

            int[] result = FindTheMinimumIndexInAnArray(array);
            Console.WriteLine($"Индекс максимального числа: {result[0]} {result[1]}");

        }
        public void SolveTask5()
        {
            int[,] array = AddRandomInArray(6, 6);

            int result = FindFearOfNeighbors(array);
            Console.WriteLine($"Количество чисел, которые больше соседей:{result}");

        }
        public void SolveTask6()
        {
            int[,] array = AddRandomInArray(6, 6);

            Console.WriteLine("Транспонированная матрица:");

            TransposeMatrix(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write($"{array[i, j]}\t");

                }
                Console.WriteLine();
            }

        }

        public int FindTheMinimumNumberInAnArray(int[,] array)
        {
            ThrowErrorToEmptyArray(array.GetLength(0), array.GetLength(1));

            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }

                }
            }
            return min;

        }
        public int FindTheMaximumNumberInAnArray(int[,] array)
        {
            ThrowErrorToEmptyArray(array.GetLength(0), array.GetLength(1));

            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }

                }
            }
            return max;

        }
        public int[] FindTheMinimumIndexInAnArray(int[,] array)
        {
            ThrowErrorToEmptyArray(array.GetLength(0), array.GetLength(1));

            int min = array[0, 0];
            int minI = 0;
            int minJ = 0;
            int[] inArray = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        inArray[0] = i;
                        inArray[1] = j;
                    }

                }
            }
            return inArray;
        }
        public int[] FindTheMaximumIndexInAnArray(int[,] array)
        {
            ThrowErrorToEmptyArray(array.GetLength(0), array.GetLength(1));

            int max = array[0, 0];
            int[] inArray = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        inArray[0] = i;
                        inArray[1] = j;
                    }

                }
            }
            return inArray;
        }

        public int FindFearOfNeighbors(int[,] array)
        {
            ThrowErrorToEmptyArray(array.GetLength(0), array.GetLength(1));

            int testIn = array[0, 0];
            int fearOfNeighbors = 0;

            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1] && array[i, j] > array[i, j + 1] && array[i, j] > array[i + 1, j])
                    {
                        fearOfNeighbors++;
                    }
                }
            }
            return fearOfNeighbors;
        }
        public void TransposeMatrix(int[,] array)
        {
            ThrowErrorToEmptyArray(array.GetLength(0), array.GetLength(1));

            int n = 0;
            int x = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 1 + x; j < array.GetLength(1); j++)
                {
                    n = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = n;

                }
                x++;
            }
        }





        public int[,] AddRandomInArray(int a, int b)
        {
            int[,] array = new int[a, b];
            Random rnd = new Random();


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 100);

                    Console.Write($"{ array[i, j]}\t");

                }
                Console.WriteLine();
            }
            return array;
        }

        public void ThrowErrorToEmptyArray(int i, int j)
        {
            if (i == 1 && j == 0)
            {
                throw new IndexOutOfRangeException("Передан пустой массив");
            }
        }



    }
}
