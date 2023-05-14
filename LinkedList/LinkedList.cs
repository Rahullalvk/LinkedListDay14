using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class SortedLinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else if (data.CompareTo(Head.Data) < 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null && data.CompareTo(current.Next.Data) > 0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                if (current == Tail)
                {
                    Tail = newNode;
                }
            }
        }

        public void Display()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}

