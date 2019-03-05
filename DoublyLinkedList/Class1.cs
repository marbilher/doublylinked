using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        public Node HeadNode { get; set; }
        public Node TailNode { get; set; }

        DoublyLinkedList(Node node)
        {
            HeadNode = node;
            TailNode = node;

        };

        void AddToTail(int i)
        {
           Node newNode = new Node(i);
            TailNode.next = newNode;

            newNode.prev = TailNode;

            TailNode = newNode;
        }





    }
}
