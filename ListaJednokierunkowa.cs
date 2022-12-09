using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaJednokierunkowa
{


    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        private Node head;

        public static void Main(string[] args)
        {
            var list = new LinkedList();

            list.AddToFront(1);
            list.AddToFront(1);
            list.RemoveFirst();
            list.AddToEnd(2);
            list.AddToEnd(3);
            list.AddToFront(0);
            list.RemoveLast();

            list.Print();
        }

        public void AddToFront(int data)
        {
            var node = new Node
            {
                Data = data,
                Next = head
            };

            head = node;
        }

        public void AddToEnd(int data)
        {
            var node = new Node { Data = data };

            if (head == null)
            {
                head = node;
                return;
            }

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            var current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public void Print()
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}