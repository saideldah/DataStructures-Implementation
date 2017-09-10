using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T Value { set; get; }
        public LinkedListNode<T> Next { set; get; }
        public LinkedListNode()
        {
            this.Next = null;
        }
        public LinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
