using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void InsertAfter(int key, int data)
        {
            Node newNode = new Node(data);

            Node current = Head;
            while (current != null)
            {
                if (current.Data == key)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    if (current == Tail)
                    {
                        Tail = newNode;
                    }
                    break;
                }
                current = current.Next;
            }
        }

        public void Delete(int key)
        {
            if (Head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            if (Head.Data == key)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == key)
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Tail = current;
                    }
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine($"Node with key value {key} not found.");
        }

        public int Size()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}



