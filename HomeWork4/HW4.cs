using System;

namespace HomeWork4
{
    public class HW4

    {
        public void SolveTask1()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);

            int result = FindTheMinimumNumberInAnArray(array);
            Console.WriteLine($"Минимальное число в массиве: {result}");
        }
        public void SolveTask2()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);

            int result = FindTheMaximumNumberInAnArray(array);
            Console.WriteLine($"Максимальное число в массиве: {result}");
        }
        public void SolveTask3()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);

            int result = FindTheMinimumIndexInAnArray(array);
            Console.WriteLine($"Индекс у минимального числа: {result}");
        }
        public void SolveTask4()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);

            int result = FindTheMaximumIndexInAnArray(array);
            Console.WriteLine($"Индекс у максимального числа: {result}");
        }
        public void SolveTask5()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);

            int result = CalculateTheSumOddIndices(array);
            Console.WriteLine($"Сумма чисел у нечетных индексов: {result}");
        }
        public void SolveTask6()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);
            Console.WriteLine();
            FlipArray(array);
            DisplayArray(array);

        }
        public void SolveTask7()
        {
            int[] array = AddRandomInArray(3);
            DisplayArray(array);

            int result = CountTheNumberOfOddElements(array);
            Console.WriteLine($"Количество нечетных элементов в массиве: {result}");
        }
        public void SolveTask8()
        {
            int[] array = AddRandomInArray(20);
            DisplayArray(array);

             SwapParts(array);
            Console.WriteLine("Изменили части массива:");
            DisplayArray(array);

        }
        public void SolveTask9()
        {
            int[] array = AddRandomInArray(20);

            DisplayArray(array);


            BubbleSort(array);

            Console.WriteLine("Отсортировали:");
            DisplayArray(array);

        }
        public void SolveTask10()
        {
            int[] array = AddRandomInArray(20);

            DisplayArray(array);


            InsertSort(array);

            Console.WriteLine("Отсортировали в порядке убывания:");
            DisplayArray(array);

        }
        public void DisplayArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
        }
        public int FindTheMinimumNumberInAnArray(int[] array)
        {
            int min = array[1];

            Console.WriteLine();

            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }
        public int FindTheMaximumNumberInAnArray(int[] array)
        {
            int max = array[1];

           


            Console.WriteLine();

            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }
        public int FindTheMinimumIndexInAnArray(int[] array)
        {
            int min = array[0];
            int minIn = 0;
           


            Console.WriteLine();

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    minIn = index;
                    min = array[index];
                }
            }
            return minIn;
        }
        public int FindTheMaximumIndexInAnArray(int[] array)
        {
            int max = array[0];
            int maxIn = 0;
           


            Console.WriteLine();
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    maxIn = index;
                    max = array[index];
                }
            }
            return maxIn;
        }
        public int CalculateTheSumOddIndices(int[] array)
        {
            int oddIn = 0;
           


            for (int index = 0; index < array.Length; index++)
            {
                if (index % 2 != 0)
                {
                    oddIn = oddIn + array[index];
                }

            }
            return oddIn;
        }
        public void FlipArray(int[] array)
        {
            int endArray = array.Length - 1;
            int temp = 0;
            int halfArray = array.Length / 2;
           

            for (int index = 0; index < halfArray; index++)
            {
                temp = array[endArray];
                array[endArray] = array[index];
                array[index] = temp;
                endArray--;
            }
        }

        public int[] AddRandomInArray(int a)
        {
            Random rnd = new Random();

            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            return array;
        }

        public int CountTheNumberOfOddElements(int[] array)

        {
            int oddEq = 0;

           


            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] % 2 != 0)
                {
                    
                    oddEq += 1;
                }

            }
            return oddEq;
        }

        public void SwapParts(int[] array)
        {

           


            int half = array.Length / 2;
            int n = array.Length % 2;
            int p = 0;

            for (int index = 0; index < half; index++)
            {
                p = array[index];
                array[index] = array[index + half + n];
                array[index + half + n] = p;
            }

        }

        public void BubbleSort(int[] array)
        {
            bool test = true;
            int n = 0;
            while (test)
            {
                test = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        n = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = n;
                        test = true;
                    }

                }


            }
        }
        public void InsertSort(int[] array)
        {
            int max = 0;
            int endAr = array.Length - 1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int minIndex = i;
                int minValue = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] < minValue)
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }

                minValue = array[i];
                array[i] = array[minIndex];
                array[minIndex] = minValue;
            }

        }
    }
}
