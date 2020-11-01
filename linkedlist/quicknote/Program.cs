using System;

namespace quicknote
{
    class Program
    {
    class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            // constr for linked list
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
            int count;

            public LinkedList()
            {
                head = null;
                count = 0;
            }
            // method to add new nodes to linked list
            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void PrintList()
            {
                LinkedListNode runner = head;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(7);
            linkedList.AddNodeToFront(2);
            linkedList.AddNodeToFront(3);
            linkedList.AddNodeToFront(11);
            linkedList.AddNodeToFront(72);
            // prints backwards because the last number takes over the head
            linkedList.PrintList();
        }
    }
}
