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

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
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
                    break;
                }
                current = current.Next;
            }
        }

        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
        }
    }
}


