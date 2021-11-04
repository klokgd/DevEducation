using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class DoublyLinkedList : InterfaceForLists
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

            TestErrorToEmptyArray();
            _head = new DoublyLinkedListNode(value[0]);
            DoublyLinkedListNode current = _head;

            for (int i = 1; i < value.Length; i++)
            {
                current.Next = new DoublyLinkedListNode(value[i]);
                current.Prev = new DoublyLinkedListNode(value[i - 1]);
                current = current.Next;
                _tail = current;
            }
        }

        public void AddAt(int idx, int val)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(int val)
        {
            throw new NotImplementedException();
        }

        public void AddLast(int val)
        {
            throw new NotImplementedException();
        }

        public int Get(int idx)
        {
            throw new NotImplementedException();
        }

        public int GetFirst()
        {
            throw new NotImplementedException();
        }

        public int GetLast()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int val)
        {
            throw new NotImplementedException();
        }

        public int IndexOfMax()
        {
            throw new NotImplementedException();
        }

        public int IndexOfMin()
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int RemoveAll(int val)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int idx)
        {
            throw new NotImplementedException();
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public int RemoveFirst(int val)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirstMultiple(int n)
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

        public void RemoveLastMultiple(int n)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void Set(int idx, int val)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public void SortDesc()
        {
            throw new NotImplementedException();
        }

        public int[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
