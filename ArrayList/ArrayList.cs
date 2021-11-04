using System;

namespace Lists
{
    public class ArrayList : InterfaceForLists
    {
        public int RealLength { get; private set; }
        private int[] _array;

        public ArrayList()
        {
            RealLength = 0;
            _array = new int[10];
        }
        public ArrayList(int number)
        {

            RealLength = 1;
            _array = new int[10];
            _array[0] = number;
        }
        public ArrayList(int[] array)
        {
            _array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }

            RealLength = array.Length;


        }


        public void AddLast(int number)
        {

            while (_array.Length < RealLength + 1)
            {
                ExtendLengthArray();
            }

            _array[RealLength] = number;

            RealLength++;
        }

        public void ExtendLengthArray()
        {
            int[] temp = _array;
            int newLength = 0;
            TestIfEmptyArray();
            newLength = (_array.Length * 3) / 2 + 1;
            _array = new int[newLength];
            for (int i = 0; i < temp.Length; i++)
            {
                _array[i] = temp[i];
            }
        }

        public void DecreaseLengthArray(int n)
        {
            int[] temp = _array;
            int newLength = 0;
            TestIfEmptyArray();
            newLength = _array.Length - n;
            _array = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = temp[i];
            }
        }

        public int[] ToArray()
        {

            int[] tempArray = new int[RealLength];

            for (int i = 0; i < RealLength; i++)
            {
                tempArray[i] = _array[i];
            }

            return tempArray;
        }

        public void AddFirst(int number)

        {

            while (_array.Length < RealLength + 1)
            {
                ExtendLengthArray();
            }

            for (int i = RealLength - 1; i > 0; i--)
            {

                _array[i] = _array[i - 1];
            }
            _array[0] = number;
            RealLength++;
        }




        public void AddFirst(ArrayList list)
        {
            int newRealLength = list.RealLength + RealLength;

            while (_array.Length < newRealLength)
            {
                ExtendLengthArray();
            }

            for (int i = 0; i <= RealLength; i++)
            {
                _array[newRealLength - i] = _array[RealLength - i];
            }
            for (int i = 0; i < list.RealLength; i++)
            {
                _array[i] = list._array[i];
            }

            RealLength = newRealLength;

        }

        public void AddLast(ArrayList list)
        {

            int newRealLength = list.RealLength + RealLength;

            while (_array.Length < newRealLength)
            {
                ExtendLengthArray();
            }

            for (int i = 0; i < list.RealLength; i++)
            {
                _array[i + RealLength] = list._array[i];
            }

            RealLength = newRealLength;
        }

        public void AddAt(int idx, ArrayList list)
        {
            TestErrorId(idx);

            int[] insertArray = list.ToArray();
            int[] originArray = ToArray();

            int newRealLength = RealLength + list.RealLength;


            while (_array.Length < newRealLength)
            {
                ExtendLengthArray();
            }


            for (int i = 0; i < idx; i++)
            {
                _array[newRealLength - i - 1] = _array[RealLength - i - 1];
            }
            for (int i = 0; i < list.RealLength; i++)
            {
                _array[idx + i] = list._array[i];
            }
            RealLength = newRealLength;
        }

        public void AddAt(int idx, int val)
        {
            TestErrorId(idx);

            for (int i = RealLength; i > idx; i--)
            {
                _array[i] = _array[i - 1];

            }


            _array[idx] = val;
            RealLength++;
        }
        public void Set(int idx, int val)
        {
            TestErrorId(idx);

            _array[idx] = val;
        }

        public void RemoveFirst()
        {
            TestIfEmptyArray();

            int[] tempAr = new int[RealLength - 1];

            for (int i = 0; i < tempAr.Length; i++)
            {
                tempAr[i] = _array[i + 1];
            }
            _array = tempAr;
            RealLength--;
            DecreaseLengthArray(1);
        }

        public void Reverse()
        {
            int endArray = RealLength - 1;
            int temp = 0;
            int halfArray = RealLength / 2;


            for (int index = 0; index < halfArray; index++)
            {
                temp = _array[endArray];
                _array[endArray] = _array[index];
                _array[index] = temp;
                endArray--;
            }
        }

        public void TestErrorId(int idx)
        {
            if (idx > _array.Length)
            {
                throw new IndexOutOfRangeException("Такого ID нет в массиве");
            }

        }

        public void TestIfEmptyArray()
        {
            if ((RealLength - 1) < 0)
            {
                throw new IndexOutOfRangeException("Ошибка! Передан пустой массив");

            }
        }

        public void RemoveLast()
        {
            RemoveAt(RealLength - 1);

        }

        public void RemoveAt(int idx)
        {
            TestErrorId(idx);
            TestIfEmptyArray();

            int[] tempAr = new int[RealLength - 1];


            for (int i = idx; i < RealLength; i++)
            {
                _array[i] = _array[i + 1];
            }
            DecreaseLengthArray(1);
            RealLength--;
        }

        public void RemoveFirstMultiple(int n)
        {

            for (int i = 0; i < n; i++)
            {
                RemoveAt(0);
            }
        }
        public void RemoveLastMultiple(int n)
        {
            for (int i = 0; i < n; i++)
            {
                RemoveAt(RealLength - 1);

            }
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (n > RealLength - idx)
            {
                throw new IndexOutOfRangeException("Ошибка! Диапозон больше остатка в массиве");

            }


            for (int i = 0; i < n; i++)
            {

                RemoveAt(idx);
            }

        }

        public int RemoveFirst(int val)
        {

            int idx = -1;
            int[] tempAr = new int[RealLength];

            idx = IndexOf(val);
            if (idx >= 0)
            {
                RemoveAt(idx);
            }

            return idx;
        }
        public int RemoveAll(int val)
        {

            int idx = IndexOf(val);
            int amountVal = 0;


            while (idx >= 0)
            {

                RemoveAt(idx);
                idx = IndexOf(val);
                amountVal++;

            }

            return amountVal;
        }

        public bool Contains(int val)
        {
            bool test = false;

            for (int i = 0; i < _array.Length; i++)
            {
                if (val == _array[i])
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

            for (int i = 0; i < _array.Length; i++)
            {
                if (val == _array[i])
                {
                    idx = i;
                    break;
                }
            }

            return idx;
        }
        public int GetFirst()
        {
            int firstvalue = _array[0];

            return firstvalue;
        }
        public int GetLast()
        {
            int lastvalue = _array[RealLength - 1];

            return lastvalue;
        }
        public int Get(int idx)
        {
            int targetValue = _array[idx];

            return targetValue;
        }

        public int Max()
        {
            int max = _array[0];

            for (int i = 0; i < _array.Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }

            return max;
        }
        public int Min()
        {
            int min = _array[0];

            for (int i = 0; i < RealLength; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }

            return min;
        }
        public int IndexOfMax()
        {
            int idx = 0;
            int max = _array[0];


            for (int i = 0; i < _array.Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];

                    idx = i;
                }
            }

            return idx;
        }
        public int IndexOfMin()
        {
            int idx = 0;
            int min = _array[0];


            for (int i = 0; i < RealLength; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];

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
            _array = tempAr;
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

            _array = tempAr;

        }

    }
}
