using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public class DoublyLinkedList : InterfaceForLists
    {
        private DoublyLinkedListNode _tail;
        private DoublyLinkedListNode _head;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = _head;
        }

        public DoublyLinkedList(int value)
        {
            _head = new DoublyLinkedListNode(value);
            _tail = _head;
        }
        public DoublyLinkedList(int[] value)
        {

            //TestErrorToEmptyArray();
            if (value.Length == 0)
            {
                throw new ArgumentException("Передан пустой массив");
            }

            _head = new DoublyLinkedListNode(value[0]);
            DoublyLinkedListNode current = _head;

            for (int i = 1; i < value.Length; i++)
            {
                current.Next = new DoublyLinkedListNode(value[i]);
                current.Next.Prev = current;
                current = current.Next;
                _tail = current;
            }
        }
        public DoublyLinkedListNode FindIdx(int idx)
        {
            ThrowErrorIfIdxWrong(idx);
            DoublyLinkedListNode current = _head;

            for (int i = 0; i < idx; i++)
            {

                current = current.Next;

            }
            return current;
        }

        public int GetLength()
        {

            int length = 0;
            DoublyLinkedListNode current = _head;

            while (current != null)
            {
                current = current.Next;
                length++;
            }

            return length;
        }

        public void ThrowErrorIfIdxWrong(int idx)
        {
            if (idx > GetLength())
            {
                throw new IndexOutOfRangeException("Такого ID нет в списке");
            }
        }

        public void ThrowErrorIfArrayEmpty()
        {
            if ((GetLength() - 1) <= 0)
            {
                throw new IndexOutOfRangeException("Ошибка! Передан пустой массив");

            }
        }

        public void SetTail()
        {
            DoublyLinkedListNode current = _head;

            while (current.Next != null)
            {
                current = current.Next;
                if (current.Next == null)
                {
                    _tail = current;
                }
            }
        }
        public DoublyLinkedList Clone(DoublyLinkedList list)
        {
            int[] array = list.ToArray();
            DoublyLinkedList listClone = new DoublyLinkedList(array);
            return listClone;


        }

        public void AddAt(int idx, int val)
        {

            ThrowErrorIfIdxWrong(idx);
            DoublyLinkedListNode current = FindIdx(idx - 1);


            DoublyLinkedListNode addNumber = new DoublyLinkedListNode(val);

            if (idx == 0)
            {
                AddFirst(val);
            }
            else
            {
                addNumber.Next = current.Next;
                addNumber.Prev = current;
                current.Next = addNumber;
            }
            SetTail();
        }

        public void AddAt(int idx, DoublyLinkedList list)
        {
            DoublyLinkedListNode current = FindIdx(idx - 1);
            DoublyLinkedList cloneList = Clone(list);
            DoublyLinkedListNode value = cloneList._head;
            DoublyLinkedListNode secondPart = new DoublyLinkedListNode(0);
            if (idx == 0)
            {
                AddFirst(cloneList);
            }
            else
            {
                secondPart = current.Next;
                cloneList._head.Prev = current;
                current.Next = cloneList._head;
                secondPart.Prev = cloneList._tail;
                cloneList._tail.Next = secondPart;
            }
            SetTail();
        }

        public void AddFirst(int val)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(val);
            node.Next = _head;
            node.Next.Prev = node;
            _head = node;
        }
        public void AddFirst(DoublyLinkedList list)
        {
            DoublyLinkedList listClone = Clone(list);

            listClone._tail.Next = _head;
            _head.Prev = listClone._tail;
            _head = listClone._head;
        }

        public void AddLast(int val)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(val);
            _tail.Next = node;
            node.Prev = _tail;
            _tail = _tail.Next;
        }

        public void AddLast(DoublyLinkedList list)
        {
            DoublyLinkedList listClone = Clone(list);

            listClone._head.Prev = _tail;
            _tail.Next = listClone._head;
            _tail = listClone._tail;
        }

        public int Get(int idx)
        {
            int value = 0;
            ThrowErrorIfIdxWrong(idx);

            DoublyLinkedListNode current = _head;

            for (int i = 0; i < idx; i++)
            {

                current = current.Next;

            }
            value = current.Value;

            return value;
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

        public int IndexOf(int val)
        {
            DoublyLinkedListNode current = _head;
            int index = -1;
            int length = GetLength();

            for (int i = 0; i < length; i++)
            {
                if (current.Value == val)
                {
                    index = i;
                    break;

                }
                current = current.Next;
            }

            return index;
        }

        public int IndexOfMax()
        {

            int max = _head.Value;
            int index = 0;
            DoublyLinkedListNode current = _head;
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

        public int IndexOfMin()
        {
            int min = _head.Value;
            int index = 0;
            int length = GetLength();
            DoublyLinkedListNode current = _head;

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

        public int Max()
        {

            int max = _head.Value;

            DoublyLinkedListNode current = _head;
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

        public int Min()
        {
            int min = _head.Value;

            DoublyLinkedListNode current = _head;
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

        public int RemoveAll(int val)
        {
            DoublyLinkedListNode current = _head;
            int qualityNumbers = 0;

            while (current != null && current.Next != null)
            {
                while (current.Value == val)
                {
                    RemoveFirst();
                    current = current.Next;
                }
                while (current.Next.Value == val)
                {
                    if (current.Next.Next == null)
                    {
                        current.Next = null;
                    }
                    else
                    {
                        current.Next = current.Next.Next;
                        current.Next.Prev = current;
                    }
                    qualityNumbers++;
                    if (current.Next == null)
                    {
                        break;
                    }
                }
                current = current.Next;
            }

            SetTail();
            return qualityNumbers;
        }

        public void SwapNodes(int a, int b)
        {



            DoublyLinkedListNode currentInterval = FindIdx(a);
            DoublyLinkedListNode currentMaxValue = FindIdx(b);
        


            if (a == b)
            {
                return;
            }
            

            if (currentInterval.Prev != null)
            {
                currentInterval.Prev.Next = currentMaxValue;
            }
            else
            {
                _head = currentMaxValue;
            }


            currentMaxValue.Prev.Next = currentInterval;


            DoublyLinkedListNode temp1 = currentMaxValue.Prev;
            currentMaxValue.Prev = currentInterval.Prev;
            currentInterval.Prev = temp1;

            DoublyLinkedListNode temp = currentInterval.Next;
            currentInterval.Next = currentMaxValue.Next;
            currentMaxValue.Next = temp;
        }

        public void RemoveAt(int idx)
        {
            DoublyLinkedListNode current = FindIdx(idx - 1);

            if (idx == 0)
            {
                RemoveFirst();
            }
            else
            {
                if (current.Next.Next == null)
                {
                    current.Next = null;
                }
                else
                {
                    current.Next = current.Next.Next;

                    current.Next.Prev = current;
                }

            }
            SetTail();
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            int testLength = idx + n;
            ThrowErrorIfIdxWrong(testLength);

            DoublyLinkedListNode current = FindIdx(idx - 1);

            DoublyLinkedListNode interval = _head;

            for (int i = 0; i < (idx + n) - 1; i++)
            {

                interval = interval.Next;

            }

            current.Next = interval.Next;
            if (current.Next != null)
            {
                current.Next.Prev = current;
            }

            if (idx == 0)
            {
                RemoveFirst();
            }
            SetTail();
        }

        public void RemoveFirst()
        {
            ThrowErrorIfArrayEmpty();
            if (_head.Next == null)
            {
                _head = null;
                _tail = _head;
            }
            else
            {

                _head = _head.Next;
                _head.Prev = null;
            }
        }

        public int RemoveFirst(int val)
        {
            DoublyLinkedListNode current = _head;
            int index = 0;
            if (current.Value == val)
            {
                RemoveFirst();

            }
            else
            {
                while (current.Next != null)
                {
                    index++;
                    if (current.Next.Value == val)
                    {
                        current.Next = current.Next.Next;
                        current.Next.Prev = current;
                        break;
                    }
                    current = current.Next;
                }
            }
            return index;
        }

        public void RemoveFirstMultiple(int n)

        {
            int interval = GetLength() - n;
            if (interval < 0)
            {
                throw new ArgumentException("Переданное число больше длинны листа");

            }
            else if (interval == 0)
            {
                _head = null;
                _tail = _head;
            }
            else
            {
                DoublyLinkedListNode current = FindIdx(n - 1);
                _head = current.Next;
                _head.Prev = null;
            }
        }

        public void RemoveLastMultiple(int n)
        {
            int interval = GetLength() - n;
            if (interval == 0)
            {
                _head = null;
                _tail = _head;
            }
            else if (interval < 0)
            {
                throw new ArgumentException("Переданное число больше длинны листа");
            }
            else
            {
                DoublyLinkedListNode current = FindIdx(interval - 1);
                current.Next = null;
                _tail = current;
            }
        }

        public void RemoveLast()
        {
            DoublyLinkedListNode current = _head;
            if (current.Next == null)
            {
                RemoveFirst();
            }
            else
            {
                while (current.Next.Next != null)
                {
                    current = current.Next;

                }
                current.Next = null;
                _tail = current;
            }
        }


        public void Reverse()
        {

            DoublyLinkedListNode current = _head;

            while (current != null)
            {
                DoublyLinkedListNode temp = current.Next;
                DoublyLinkedListNode temp2 = current.Prev;
                current.Prev = temp;
                current.Next = temp2;
                _head = current;
                current = temp;


            }

            SetTail();
        }

        public void Set(int idx, int val)
        {
            DoublyLinkedListNode current = FindIdx(idx);
            current.Value = val;
        }

        public void Sort()
        {
            int length = GetLength();

            DoublyLinkedListNode interval = _head;
            for (int i = 0; i < length; i++)
            {

                interval = FindIdx(i);
                DoublyLinkedListNode current = interval.Next;
                int minIndex = i;
                int minValue = interval.Value;
                for (int j = i + 1; j < length; j++)
                {

                    if (minValue > current.Value)
                    {
                        minValue = current.Value;
                        minIndex = j;
                    }
                    current = current.Next;
                }
                SwapNodes(i, minIndex);

            }
            SetTail();
        }

        public void SortDesc()
        {

            int length = GetLength();

            DoublyLinkedListNode interval = _head;
            for (int i = 0; i < length; i++)
            {

                interval = FindIdx(i);
                DoublyLinkedListNode current = interval.Next;
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
                SwapNodes(i, maxIndex);

            }
            SetTail();
            
        }

        public int[] ToArray()
        {
            int[] tempAr = new int[GetLength()];
            DoublyLinkedListNode current = _head;
            int length = GetLength();

            for (int i = 0; i < length; i++)
            {
                tempAr[i] = current.Value;
                current = current.Next;
            }
            return tempAr;
        }

        public bool Contains(int val)
        {
            bool test = false;

            DoublyLinkedListNode current = _head;


            while (current.Next != null)
            {
                if (current.Value == val)
                {
                    test = true;
                    break;
                }
                current = current.Next;
            }

            return test;
        }
    }
}
