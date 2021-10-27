using L_Lists;
using System;

namespace L_Lists
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
            _tail = _head;
            if (GetLength() > 1)
            {
                for (int i = 1; i < GetLength() - 1; i++)
                {
                    _tail.Next = new Node(value[i]);
                    _tail = _tail.Next;
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

       

    }
}
