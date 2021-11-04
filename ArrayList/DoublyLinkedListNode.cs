using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public class DoublyLinkedListNode
    {
        public int Value { get; set; }
        public DoublyLinkedListNode Next { get; set; }
        public DoublyLinkedListNode Prev { get; set; }
        public DoublyLinkedListNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
