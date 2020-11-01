using System;

namespace quicknote
{
    class Program
    {
        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            // constructer for linked list
            public LinkedListNode(int x) 
            {
                data = x; 
                next = null;
            }
        }

        class LinkedList
        {
            //whenever we create a link list we want a way to ref the beggining of the list.
            LinkedListNode head;

            // method to add new nodes to linked list
            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
    }



}
