using System;
using Xunit;
using DoublyLinkedList;

namespace DoublyLinkedListTest
{
    public class UnitTest1
    {
    

        [Theory]
        [InlineData(6)]
        public void AddToTailTest(int input)
        {
            Node newNode = new Node(5);
            DoublyLinkedList doublyLinked = new DoublyLinkedList(newNode);

            doublyLinked.AddToTail(input);
            Assert.Equals(input, doublyLinked.Tail.Value);
        }
    }
}
