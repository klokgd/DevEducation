using System;

namespace Lists
{
    public class ArrayList
    {
        public int RealLength { get; private set; }
        public int[] array { get; private set; }

        public ArrayList()
        {
            RealLength = 0;
            array = new int[10];
        }
        public ArrayList(int number)
        {

            RealLength = 1;
            array = new int[10];
            array[0] = number;
        }
        public ArrayList(int[] GetArray)
        {
            array = new int[10];

            for (int i = 0; i < GetArray.Length; i++)
            {
                array[i] = GetArray[i];
            }

            RealLength = GetArray.Length;


        }

        public void AddLast(int number)
        {

            array[RealLength] = number;

            RealLength++;
        }

        public void UpSize()
        {
            int[] temp = array;
            int newLength = 0;

            ErrorAray(RealLength);


            if (RealLength > 1)
            {
                newLength = RealLength * 3 / 2;
                array = new int[newLength];
            }
            else if (RealLength == 1)
            {
                newLength = RealLength++;
                array = new int[newLength];
            }
            //else
            //{
            //    throw new IndexOutOfRangeException("Массив не содержит элементов");
            //}



            for (int i = 0; i < RealLength; i++)
            {
                array[i] = temp[i];
            }


        }

        public int[] ToArray()
        {

            int[] tempArray = new int[RealLength];

            for (int i = 0; i < RealLength; i++)
            {
                tempArray[i] = array[i];
            }

            return tempArray;
        }

        public void AddFirst(int number)

        {
            RealLength++;

            for (int i = RealLength - 1; i > 0; i--)
            {

                array[i] = array[i - 1];
            }
            array[0] = number;
        }




        public void AddFirst(ArrayList list)
        {
            int[] firstArray = list.ToArray();
            int[] lastArray = ToArray();
            int newLength = firstArray.Length + lastArray.Length;
            int[] newArray = new int[newLength];

            for (int i = 0; i < firstArray.Length; i++)
            {
                newArray[i] = firstArray[i];
            }

            for (int i = firstArray.Length; i < newLength; i++)
            {
                newArray[i] = lastArray[i - firstArray.Length];
            }

            array = newArray;
            RealLength = newLength;

        }

        public void AddLast(ArrayList list)
        {
            int[] firstArray = ToArray();
            int[] lastArray = list.ToArray();
            int newLength = firstArray.Length + lastArray.Length;
            int[] newArray = new int[newLength];

            for (int i = 0; i < firstArray.Length; i++)
            {
                newArray[i] = firstArray[i];
            }

            for (int i = firstArray.Length; i < newLength; i++)
            {
                newArray[i] = lastArray[i - firstArray.Length];
            }



            array = newArray;
            RealLength = newLength;
        }
        public void AddAt(int idx, ArrayList list)
        {
            int[] insertArray = list.ToArray();
            int[] originArray = ToArray();
            int newLength = insertArray.Length + originArray.Length;
            int[] newArray = new int[newLength];

            ErrorId(idx);

            for (int i = 1; i <= originArray.Length; i++)
            {
                newArray[newLength - i] = originArray[originArray.Length - i];
            }
            for (int i = 0; i < idx; i++)
            {
                newArray[i] = originArray[i];
            }
            for (int i = 0; i < insertArray.Length; i++)
            {
                newArray[i + idx] = insertArray[i];
            }

            array = newArray;
            RealLength = newLength;
        }

        public void AddAt(int idx, int val)
        {
            ErrorId(idx);

            for (int i = RealLength; i > idx; i--)
            {
                array[i] = array[i - 1];

            }


            array[idx] = val;
            RealLength++;
        }
        public void Set(int idx, int val)
        {
            ErrorId(idx);

            array[idx] = val;
        }

        public void RemoveFirst()
        {
            ErrorAray(RealLength);

            int[] tempAr = new int[RealLength - 1];

            for (int i = 0; i < tempAr.Length; i++)
            {
                tempAr[i] = array[i + 1];
            }
            array = tempAr;
            RealLength--;
        }

        public void ErrorId(int idx)
        {
            if (idx > array.Length)
            {
                throw new IndexOutOfRangeException("Такого ID нет в массиве");
            }

        }

        public void ErrorAray(int RealLength)
        {
            if ((RealLength - 1) < 0)
            {
                throw new IndexOutOfRangeException("Ошибка! Передан пустой массив");

            }
        }

        public void RemoveLast()
        {
            ErrorAray(RealLength);

            int[] tempAr = new int[RealLength - 1];

            for (int i = 0; i < tempAr.Length; i++)
            {
                tempAr[i] = array[i];
            }
            array = tempAr;
            RealLength--;
        }

        public void RemoveAt(int idx)
        {
            ErrorId(idx);

            int[] tempAr = new int[RealLength - 1];


            for (int i = idx; i < tempAr.Length; i++)
            {
                tempAr[i] = array[i + 1];
            }
            for (int i = idx - 1; i >= 0; i--)
            {
                tempAr[i] = array[i];
            }


            array = tempAr;
            RealLength--;
        }

        public void RemoveFirstMultiple(int n)
        {

            int[] tempAr = new int[RealLength - n];

            for (int i = 0; i < tempAr.Length; i++)
            {
                tempAr[i] = array[n + i];
            }

            array = tempAr;

            RealLength -= n;
        }
        public void RemoveLastMultiple(int n)
        {
            int[] tempAr = new int[RealLength - n];

            for (int i = 0; i < tempAr.Length; i++)
            {
                tempAr[i] = array[i];
            }

            array = tempAr;

            RealLength -= n;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            int[] tempAr = new int[RealLength - n];
            if (idx + n >= array.Length - idx)
            {
                throw new IndexOutOfRangeException("Ошибка! Число больше остатка в массиве");

            }

            for (int i = 0; i + idx + n < array.Length; i++)
            {
                tempAr[i + idx] = array[i + idx + n];
            }
            for (int i = idx - 1; i >= 0; i--)
            {
                tempAr[i] = array[i];
            }

            array = tempAr;

            RealLength -= n;
        }

        public int RemoveFirst(int val)
        {

            int idx = -1;
            int[] tempAr = new int[RealLength];


            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    idx = i;
                    tempAr = new int[RealLength - 1];

                    for (int j = idx; j < tempAr.Length; j++)
                    {
                        tempAr[j] = array[j + 1];
                    }
                    for (int j = idx - 1; j >= 0; j--)
                    {
                        tempAr[j] = array[j];
                    }
                    array = tempAr;
                    RealLength--;
                    break;
                }
            }

           

            return idx;
        } 
        public int RemoveAll(int val)
        {

            int idx = 0;
            int amountVal = 0;
            
            int[] tempAr = array;

            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        tempAr[j] = array[j + 1];
                    }

                    
                }


            }


            array = tempAr;

            //if (RealLength == tempAr.Length)
            //{
            //    throw new ArgumentException("Ошибка! Числа не встречается в массиве");
            //}

            return idx;
        }

        public bool Contains(int val)
        {
            bool test = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    test = true;
                    break;
                }
            }

            return test; 
        }
        public int IndexOf(int val)
        {
            int idx = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    idx = i;
                    break;
                }
            }

            return idx; 
        } 
        
        public int GetFirst()
        {
            int firstvalue = array[0];

            return firstvalue; 
        } 
        public int GetLast()
        {
            int lastvalue = array[RealLength - 1];

            return lastvalue; 
        } 
        public int Get(int idx)
        {
            int targetValue = array[idx];

            return targetValue; 
        }

        public int Max()
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }
        public int Min()
        {
            int min = array[0];

            for (int i = 0; i < RealLength; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }
        public int IndexOfMax()
        {
            int idx = 0;
            int max = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];

                    idx = i;
                }
            }

            return idx;
        }
        public int IndexOfMin()
        {
            int idx = 0;
            int min = array[0];


            for (int i = 0; i < RealLength; i++)
            {
                if (min > array[i])
                {
                    min = array[i];

                    idx = i;
                }
            }

            return idx;
        }

        public void Sort()
        {
            bool test = true;
            int n = 0;
            int[] tempAr = ToArray();

            while (test)
            {
                test = false;

                for (int i = 0; i < tempAr.Length - 1; i++)
                {
                    if (tempAr[i] > tempAr[i + 1])
                    {
                        n = tempAr[i];
                        tempAr[i] = tempAr[i + 1];
                        tempAr[i + 1] = n;
                        test = true;
                    }

                }
            }
            array = tempAr;
        }

        public void SortDesc()
        {
            int endAr = RealLength - 1;
            int[] tempAr = ToArray();
            for (int i = RealLength - 1; i >= 0; i--)
            {
                int minIndex = i;
                int minValue = tempAr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (tempAr[j] < minValue)
                    {
                        minValue = tempAr[j];
                        minIndex = j;
                    }
                }

                minValue = tempAr[i];
                tempAr[i] = tempAr[minIndex];
                tempAr[minIndex] = minValue;
            }

            array = tempAr;

        }

    }
}
