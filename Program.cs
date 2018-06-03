using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public Node Head { get; set; }
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int d, Node next = null)
            {
                Data = d;
                Next = next;
            }
        }

        public void InsertNode(Node newNode)
        {
            if (Head.Data >= newNode.Data || Head == null)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null && current.Next.Data < newNode.Data)
                    current = current.Next;

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void DeleteNode(Node head, Node target)
        {
            if (target == head)
            {
                if (head.Next == null)
                    throw new InvalidOperationException();
                head.Data = head.Next.Data;
                head.Next = head.Next.Next;
            }
                
            else
            {
                Node previous = head;
                while (previous.Next != target && previous.Next != null)
                    previous = previous.Next;

                if (previous.Next == null)
                {
                    Console.WriteLine("Node not present in Linked List");
                    return;
                }

                previous.Next = previous.Next.Next;
            }
        }
    }
}
