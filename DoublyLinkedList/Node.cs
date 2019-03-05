using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PreviousNode { get; set; }


        Node(int i)
        {
            Value = i;
        }
    }
}
