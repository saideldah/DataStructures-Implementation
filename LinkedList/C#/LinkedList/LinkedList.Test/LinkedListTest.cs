using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
namespace LinkedList.Test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void AddNodeToFirst()
        {
            LinkedList<int> myList = new LinkedList<int>();
            LinkedListNode<int> myNode = new LinkedListNode<int>();
            myNode.Value = 5;
            myList.AddFirst(myNode);
            Assert.AreEqual(myList.Head.Value, myNode.Value);
        }

        [TestMethod]
        public void AddNodeToLast()
        {
            LinkedList<int> myList = new LinkedList<int>();
            LinkedListNode<int> myNode = new LinkedListNode<int>();
            myNode.Value = 5;
            myList.AddLast(myNode);
            Assert.AreEqual(myList.Tail.Value, myNode.Value);
        }
        [TestMethod]
        public void AddValueToFirst()
        {
            int input = 5;
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(input);
            Assert.AreEqual(myList.HeadValue, input);
        }

        [TestMethod]
        public void AddValueToLast()
        {
            int input = 5;
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddLast(input);
            Assert.AreEqual(myList.TailValue, input);
        }
    }
}
