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


