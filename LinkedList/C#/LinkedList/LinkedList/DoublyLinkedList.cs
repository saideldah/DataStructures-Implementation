using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublyLinkedList<T>
    {
        #region Properties
        public int Count { private set; get; }
        public DoublyLinkedListNode<T> Head { private set; get; }
        public T HeadValue
        {
            get
            {
                if (this.Head != null)
                {
                    return this.Head.Value;
                }
                else
                {
                    return default(T);
                }
            }
        }
        public DoublyLinkedListNode<T> Tail { private set; get; }
        public T TailValue
        {
            get
            {
                if (this.Tail != null)
                {
                    return this.Tail.Value;
                }
                else
                {
                    return default(T);
                }
            }
        }
        #endregion
        #region Constructors
        public DoublyLinkedList()
        {
            this.Count = 0;
            this.Head = null;
            this.Tail = null;
        }
        #endregion
        #region Add
        //O(1)
        public void AddFirst(DoublyLinkedListNode<T> node)
        {
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                node.Next = this.Head;
                this.Head = node;
            }
            this.Count++;
        }
        //O(1)
        public void AddFirst(T vlaue)
        {
            DoublyLinkedListNode<T> node = new DoublyLinkedListNode<T>(vlaue);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                node.Next = this.Head;
                this.Head = node;
            }
            this.Count++;
        }

        //O(1)
        public void AddLast(DoublyLinkedListNode<T> node)
        {
            if (this.Tail == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                this.Tail.Next = node;
                node.Previous = this.Tail;
                this.Tail = node;
            }
            this.Count++;
        }
        //O(1)
        public void AddLast(T vlaue)
        {
            DoublyLinkedListNode<T> node = new DoublyLinkedListNode<T>(vlaue);
            if (this.Tail == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                this.Tail.Next = node;
                node.Previous = this.Tail;
                this.Tail = node;
            }
            this.Count++;
        }

        //O(n)
        public void Add(DoublyLinkedListNode<T> node, int index)
        {
            DoublyLinkedListNode<T> cur = this.Head;
            int c = 0;
            while (cur != null)
            {
                if (c == index)
                {
                    if (c == 0)
                    {
                        this.AddFirst(node);
                        cur = null;
                    }
                    else if (c == this.Count)
                    {
                        this.AddLast(node);
                        cur = null;
                    }
                    else
                    {
                        node.Previous = cur.Previous;
                        cur.Previous = node;
                        node.Next = cur;
                        cur = null;
                    }
                    this.Count++;
                }
                cur = cur.Next;
                c++;
            }
        }

        public void Add(T vlaue, int index)
        {
            DoublyLinkedListNode<T> node = new DoublyLinkedListNode<T>(vlaue);
            DoublyLinkedListNode<T> cur = this.Head;
            int c = 0;
            while (cur != null)
            {
                if (c == index)
                {
                    if (c == 0)
                    {
                        this.AddFirst(node);
                        cur = null;
                    }
                    else if (c == this.Count)
                    {
                        this.AddLast(node);
                        cur = null;
                    }
                    else
                    {
                        node.Previous = cur.Previous;
                        cur.Previous = node;
                        node.Next = cur;
                        cur = null;
                    }
                    this.Count++;
                }
                cur = cur.Next;
                c++;
            }
        }
        #endregion
        #region Remove
        //O(1)
        public void RemoveFirst()
        {
            if (this.Head != null)
            {
                var temp = this.Head;
                this.Head = this.Head.Next;
                temp.Next = null;
                this.Count--;
            }

        }
        //O(1)
        public void RemoveLast()
        {
            if (this.Tail != null)
            {  
                this.Tail = this.Tail.Previous;
                this.Tail.Next = null;
                this.Count--;
            }
        }

        //O(n)
        public void Remove(int index)
        {
            DoublyLinkedListNode<T> cur = this.Head;
            int c = 0;
            while (cur != null)
            {
                if (c == index)
                {
                    if (c == 0)
                    {
                        this.RemoveFirst();
                        cur = null;
                    }
                    else if (c == this.Count)
                    {
                        this.RemoveLast();
                        cur = null;
                    }
                    else
                    {
                        cur.Previous.Next = cur.Next;
                        cur.Next = null;
                        cur.Previous = null;
                        this.Count--;
                    }
                }
                cur = cur.Next;
                c++;
            }
        }
        #endregion

        #region Get
        //O(n)
        public T Get(int index)
        {
            int c = 0;
            DoublyLinkedListNode<T> cur = this.Head;
            bool found = false;
            while (cur != null)
            {
                if (c == index)
                {
                    found = true;
                    break;
                }
                cur = cur.Next;
                c++;
            }
            if (found)
            {
                return cur.Value;
            }
            else
            {
                return default(T);
            }
        }

        //O(n)
        public DoublyLinkedListNode<T> GetNode(int index)
        {
            int c = 0;
            DoublyLinkedListNode<T> cur = this.Head;
            while (cur != null)
            {
                if (c == index)
                {
                    break;
                }
                cur = cur.Next;
                c++;
            }
            return cur;
        }
        #endregion
        #region Clear
        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }
        #endregion
    }
}
