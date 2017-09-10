using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublyLinkedListNode<T>
    {
        public T Value { set; get; }
        public DoublyLinkedListNode<T> Previous { set; get; }
        public DoublyLinkedListNode<T> Next { set; get; }
        public DoublyLinkedListNode()
        {
            this.Previous = null;
            this.Next = null;
        }
        public DoublyLinkedListNode(T value)
        {
            this.Value = value;
            this.Previous = null;
            this.Next = null;
        }
    }
}
