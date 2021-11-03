using System;

namespace Lists
{


    public class LinkedList
    {
        private Node _tail;
        private Node _head;

        public LinkedList()
        {
            _head = null;
            _tail = _head;
        }

        public LinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }
        public LinkedList(int[] value)
        {
            if (value.Length < 1)
            {
                throw new IndexOutOfRangeException("Передан пустой массив");
            }
            _head = new Node(value[0]);
            Node current = _head;

            for (int i = 1; i < value.Length; i++)
            {
                current.Next = new Node(value[i]);
                current = current.Next;
                _tail = current;
            }
        }

        public int GetLength()
        {

            int length = 0;
            Node current = _head;

            while (current != null)
            {
                current = current.Next;
                length++;
            }

            return length;
        }

        public int[] ToArray()
        {
            int[] tempAr = new int[GetLength()];
            Node current = _head;
            int length = GetLength();

            for (int i = 0; i < length; i++)
            {
                tempAr[i] = current.Value;
                current = current.Next;
            }
            return tempAr;
        }
        public LinkedList Clone(LinkedList list)
        {
            int[] array = list.ToArray();
            LinkedList listClone = new LinkedList(array);
            return listClone;


        }

        public void AddFirst(int val)
        {
            Node node = new Node(val);
            node.Next = _head;
            _head = node;

        }
        public void AddFirst(LinkedList list)
        {
            LinkedList listClone = Clone(list);

            listClone._tail.Next = _head;
            _head = listClone._head;
            //for (int i = 0; i < val.Length; i++)
            //{
            //    Node node = new Node(val[i]);
            //    node.Next = _head;
            //    _head = node;
            //}


        }
        public void AddLast(int val)
        {
            Node node = new Node(val);
            _tail.Next = node;
            _tail = _tail.Next;

        }
        public void AddLast(LinkedList list)
        {
            _tail.Next = list._head;
            _tail = list._tail;

            //for (int i = 0; i < val.Length; i++)
            //{
            //    Node node = new Node(val[i]);
            //    _tail.Next = node;
            //    _tail = _tail.Next;
            //}
        }

        public void AddAt(int idx, int val)
        {
            ErrorIdx(idx);
            Node current = FindIdx(idx);


            Node addNumber = new Node(val);
            if (idx == 0)
            {
                AddFirst(val);
            }
            else
            {
                addNumber.Next = current.Next;

                current.Next = addNumber;
            }
        }



        public void AddAt(int idx, LinkedList list)
        {
            Node current = FindIdx(idx);
            if (idx == 0)
            {
                AddFirst(list);
            }
            else
            {
                for (int j = 0; j < list.GetLength(); j++)
                {

                    //Node addNumber = new Node(val[j]);
                    //addNumber.Next = current.Next;
                    //current.Next = addNumber;
                    //current = current.Next;
                }
            }

        }

        public void Set(int idx, int val)
        {
            Node current = FindIdx(idx);

            Node newNumber = new Node(val);
            newNumber.Next = current.Next.Next;
            current.Next = newNumber;


        }

        public void RemoveFirst()
        {
            _head = _head.Next;
        }
        public void RemoveLast()
        {
            Node current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;

            }
            current.Next = null;

        }

        public void RemoveAt(int idx)
        {
            Node current = FindIdx(idx);

            if (idx == 0)
            {
                RemoveFirst();
            }
            else
            {
                current.Next = current.Next.Next;
            }


        }



        public void RemoveFirstMultiple(int n)
        {
            Node current = FindIdx(n);
            _head = current.Next;
        }

        public void RemoveLastMultiple(int n)
        {
            Node current = FindIdx(n);
            current.Next = null;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            ErrorIdx(idx);

            Node current = FindIdx(idx);

            Node interval = _head;

            for (int i = 0; i < (idx + n) - 1; i++)
            {

                interval = interval.Next;

            }

            current.Next = interval.Next;
            if (idx == 0)
            {
                RemoveFirst();
            }

        }

        public int RemoveFirst(int val)
        {
            Node current = _head;
            int index = 0;
            while (current.Value != val)
            {
                current = current.Next;
                index++;
            }

            Node tempCurrent = FindIdx(index);
            tempCurrent.Next = tempCurrent.Next.Next;

            return index;
        }
        public void RemoveAll(int val)
        {
            Node current = _head;
            int qualityNumbers = 0;
            int length = GetLength();

            for (int i = 0; i < length; i++)
            {
                if (current.Value == val)
                {
                    qualityNumbers++;

                }
                current = current.Next;
            }

            for (int i = 0; i < qualityNumbers; i++)
            {
                int index = 0;

                current = _head;

                while (current.Value != val)
                {
                    current = current.Next;
                    index++;
                }

                Node tempCurrent = FindIdx(index);
                tempCurrent.Next = tempCurrent.Next.Next;
            }


        }

        public bool Contains(int val)
        {
            bool test = false;

            Node current = _head;
            int length = GetLength();


            for (int i = 0; i < length; i++)
            {
                if (current.Value == val)
                {
                    test = true;
                }
                current = current.Next;
            }

            return test;
        }
        public int IndexOf(int val)
        {

            Node current = _head;
            int index = -1;
            int length = GetLength();

            for (int i = 0; i < length; i++)
            {
                if (current.Value == val)
                {
                    break;
                    index = i;

                }
                current = current.Next;
            }

            return index;
        }

        public int GetFirst()
        {
            int first = _head.Value;
            return first;
        }
        public int GetLast()
        {
            int last = _tail.Value;
            return last;
        }

        public int Get(int idx)
        {
            int value = 0;
            ErrorIdx(idx);

            Node current = _head;

            for (int i = 0; i < idx; i++)
            {

                current = current.Next;

            }
            value = current.Value;

            return value;
        }

        public int Max()
        {
            int max = _head.Value;

            Node current = _head;
            int length = GetLength();


            for (int i = 0; i < length; i++)
            {
                if (current.Value > max)
                {
                    max = current.Value;
                }
                current = current.Next;
            }
            return max;

        }
        public int IndexOfMax()
        {
            int max = _head.Value;
            int index = 0;
            Node current = _head;
            int length = GetLength();

            for (int i = 0; i < length; i++)
            {
                if (current.Value > max)
                {
                    max = current.Value;
                    index = i;
                }
                current = current.Next;
            }
            return index;

        }
        public int Min()
        {
            int min = _head.Value;

            Node current = _head;
            int length = GetLength();


            for (int i = 0; i < length; i++)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                }
                current = current.Next;
            }
            return min;

        }
        public int IndexOfMin()
        {
            int min = _head.Value;
            int index = 0;
            int length = GetLength();
            Node current = _head;

            for (int i = 0; i < length; i++)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                    index = i;

                }
                current = current.Next;
            }
            return index;

        }

        public void Sort()
        {
            int[] tempAr = ToArray();
            bool test = true;
            int n = 0;
            int index = GetLength();

            while (test)
            {
                test = false;
                Node current = _head;

                for (int i = 0; i < index - 1; i++)
                {
                    if (current != null && current.Next != null && current.Value > current.Next.Value)
                    {
                        n = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = n;
                        test = true;
                    }
                    current = current.Next;

                }
            }


            //for (int i = 0; i < tempAr.Length; i++)
            //{
            //    current.Value = tempAr[i];
            //    current = current.Next;

            //}

        }
        public void SortDesc()
        {
            int length = GetLength();

            Node interval = _head;
            int n = 0;
            for (int i = 0; i < length; i++)
            {
                Node current = interval.Next;

                int maxIndex = i;
                int maxValue = interval.Value;
                for (int j = i + 1; j < length; j++)
                {

                    if (maxValue < current.Value)
                    {
                        maxValue = current.Value;
                        maxIndex = j;
                    }
                    current = current.Next;
                }
                n = interval.Value;
                current = FindIdx(maxIndex + 1);
                interval.Value = maxValue;
                current.Value = n;

                interval = interval.Next;
            }

            //Node current = _head;

            //for (int i = 0; i < tempAr.Length; i++)
            //{
            //    current.Value = tempAr[i];
            //    current = current.Next;

            //}
            //;
        }

        public void Reverse()
        {
            Node current = _head;
            Node next = new Node(0);
            Node prev = _head;
            int index = GetLength();

            for (int i = 0; i < index; i++)
            {
                AddFirst(current.Value);

                current = current.Next;
            }
            for (int i = 0; i < index; i++)
            {
                RemoveLast();
            }
        }

        public Node FindIdx(int idx)
        {
            ErrorIdx(idx);
            Node current = _head;

            for (int i = 0; i < idx - 1; i++)
            {

                current = current.Next;

            }
            return current;
        }

        public void ErrorIdx(int idx)
        {
            if (idx > GetLength())
            {
                throw new IndexOutOfRangeException("Такого ID нет в списке");
            }
        }
    }
}
