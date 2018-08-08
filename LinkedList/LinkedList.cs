using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic LinkedList
    class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public Node Head;
        public Node Current;
        public int Count = 0;

        public void AddAtStart(object value)
        {
            var newNode = new Node()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

        public bool RemoveAt(int index)
        {

            if (Head == null)
            {
                return false;
            }
            else
            {
                var temp1 = Head;
                for (int i = 0; i<index-2; i++)
                {
                    temp1 = temp1.Next;
                    Node temp2 = temp1.Next;
                    temp1.Next = temp2.Next;
                }
                return true;
            }
        }

        public void PrintReverse()
        {
            PrintReverse();
        }

        public bool InsertAt(int index, Object o)
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Current = Head;
                var temp1 = Head;
                if (index > 0 && index <= Count + 1)
                {
                    int x = 0;
                    while (Current != null)
                    {
                        if (x == index)
                        {
                            temp1 = Current;
                            Current = new Node();
                            Current.Next = temp1;
                        }
                        else
                        {
                            Current = Current.Next;
                        }
                    }
                }
                return true;
            }
        }
    }

    //Linked List using Generics
    class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }
        public Node<T> Head;
        public Node<T> Current;
        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

    
    
}
