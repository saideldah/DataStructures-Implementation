using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        #region Properties
        public int Count { private set; get; }
        public LinkedListNode<T> Head { private set; get; }
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
        public LinkedListNode<T> Tail { private set; get; }
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
        public LinkedList()
        {
            this.Count = 0;
            this.Head = null;
            this.Tail = null;
        }
        #endregion
        #region Add
        //O(1)
        public void AddFirst(LinkedListNode<T> node)
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

        public void AddFirst(T vlaue)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(vlaue);
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
        public void AddLast(LinkedListNode<T> node)
        {
            if (this.Tail == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                this.Tail.Next = node;
                this.Tail = node;
            }
            this.Count++;
        }
        public void AddLast(T vlaue)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(vlaue);
            if (this.Tail == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                this.Tail.Next = node;
                this.Tail = node;
            }
            this.Count++;
        }
        public void Add(LinkedListNode<T> node, int index)
        {
            LinkedListNode<T> pre = null;
            LinkedListNode<T> cur = this.Head;
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
                        pre.Next = node;
                        node.Next = cur;
                        cur = null;
                    }
                    this.Count++;
                }
                pre = cur;
                cur = cur.Next;
                c++;
            }
        }

        public void Add(T vlaue, int index)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(vlaue);
            LinkedListNode<T> pre = null;
            LinkedListNode<T> cur = this.Head;
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
                        pre.Next = node;
                        node.Next = cur;
                        cur = null;
                    }
                    this.Count++;
                }
                pre = cur;
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
        //O(n)
        public void RemoveLast()
        {
            if (this.Tail != null)
            {
                var pointer = this.Head;
                while (pointer.Next != this.Tail)
                {
                    pointer = pointer.Next;
                }
                this.Tail = pointer;
                this.Tail.Next = null;
                this.Count--;
            }
        }
        public void Remove(int index)
        {
            LinkedListNode<T> pre = null;
            LinkedListNode<T> cur = this.Head;
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
                        pre.Next = cur.Next;
                        cur.Next = null;
                        cur = null;
                        this.Count--;
                    }
                }
                pre = cur;
                cur = cur.Next;
                c++;
            }
        }
        #endregion
        #region Get
        public T Get(int index)
        {
            int c = 0;
            LinkedListNode<T> cur = this.Head;
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
        public LinkedListNode<T> GetNode(int index)
        {
            int c = 0;
            LinkedListNode<T> cur = this.Head;
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
