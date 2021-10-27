using System;

namespace Lists
{


    public class LinkedList
    {
        private Node _tail;
        private Node _head;

        public LinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }
        public LinkedList(int[] value)
        {
            _head = new Node(value[0]);
            Node current = _head;
            if (value.Length > 1)
            {
                for (int i = 1; i < value.Length; i++)
                {
                    current.Next = new Node(value[i]);
                    current = current.Next;
                    _tail = current;
                }
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

            for (int i = 0; i < GetLength(); i++)
            {
                tempAr[i] = current.Value;
                current = current.Next;
            }
            return tempAr;
        }

        public void AddFirst(int val)
        {
            Node node = new Node(val);
            node.Next = _head;
            _head = node;

        }
        public void AddFirst(int[] val)
        {

            for (int i = 0; i < val.Length; i++)
            {
                Node node = new Node(val[i]);
                node.Next = _head;
                _head = node;
            }


        }
        public void AddLast(int val)
        {
            Node node = new Node(val);
            _tail.Next = node;
            _tail = _tail.Next;

        }
        public void AddLast(int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Node node = new Node(val[i]);
                _tail.Next = node;
                _tail = _tail.Next;
            }
        }

        public void AddAt(int idx, int val)
        {
            Node current = FindIdx(idx);


            Node addNumber = new Node(val);
            addNumber.Next = current.Next;

            current.Next = addNumber;

        }



        public void AddAt(int idx, int[] val)
        {
            Node current = FindIdx(idx);

            for (int j = 0; j < val.Length; j++)
            {

                Node addNumber = new Node(val[j]);
                addNumber.Next = current.Next;
                current.Next = addNumber;
                current = current.Next;
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

            current.Next = current.Next.Next;

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
            Node current = FindIdx(idx);

            Node interval = _head;
            for (int i = 0; i < (idx + n) - 1; i++)
            {

                interval = interval.Next;

            }

            current.Next = interval.Next;

        }

        public void RemoveFirst(int val)
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


        }
        public void RemoveAll(int val)
        {
            Node current = _head;
            int qualityNumbers = 0;

            for (int i = 0; i < GetLength(); i++)
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

            for (int i = 0; i < GetLength(); i++)
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
            int index = 0;

            for (int i = 0; i < GetLength(); i++)
            {
                if (current.Value == val)
                {
                    break;
                }
                current = current.Next;
                index++;
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

            for (int i = 0; i < GetLength(); i++)
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

            for (int i = 0; i < GetLength(); i++)
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

            for (int i = 0; i < GetLength(); i++)
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

            Node current = _head;

            for (int i = 0; i < GetLength(); i++)
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
