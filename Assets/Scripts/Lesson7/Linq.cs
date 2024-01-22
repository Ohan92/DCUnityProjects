using System;

namespace Lesson7
{
    public class LinkedList<T>
    {
        internal LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public int Count { get; private set; }

        public LinkedListNode<T> Head => head;

        public LinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void AddFirst(T element)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(element);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            Count++;
        }

        public void AddLast(T element)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(element);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            head = head.Next;

            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.Previous = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (tail == null)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            tail = tail.Previous;

            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.Next = null;
            }

            Count--;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public class LinkedListNode<U>
        {
            public U Value { get; }
            internal LinkedListNode<U> Next { get; set; }
            internal LinkedListNode<U> Previous { get; set; }

            public LinkedListNode(U value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddFirst(1);
            myLinkedList.AddLast(2);
            myLinkedList.AddFirst(0);

            Console.WriteLine("Contents of the linked list:");
            PrintLinkedList(myLinkedList);
        }

        static void PrintLinkedList<T>(LinkedList<T> linkedList)
        {
            var current = linkedList.Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
