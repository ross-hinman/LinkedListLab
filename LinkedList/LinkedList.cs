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

            if (index == 0)
            {
                Head.Next = Head.Next.Next;
                --Count;
                return true;
            }
            if (index > 0 && index <= Count)
            {
                Node current = Head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                    if (i==(index-1) || index ==0)
                    {
                        current.Next = current.Next.Next;
                        ++Count;
                        return true;
                    }
                }
            }
            return false;
        }

        public void PrintReverse()
        {
            Node current = Head;
            Console.Write("Null ->");
            int i = 0;
            while (i<=Count)
            {
                for (int j = 0; j<Count; j++)
                {
                    if(current.Next !=null)
                    {
                        current = current.Next;
                    }
                    if (j==(Count-(i+1)))
                    {
                        Console.Write(current.Value);
                        Console.Write("->");
                    }
                }
                current = Head;
                i++;
            }
            Console.Write("Head");
            Console.WriteLine();
        }

        public bool InsertAt(int index, object o)
        {
            var newNode = new Node()
            {
                Value = o
            };
            if (index == 0)
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
                Count++;
                return true;
            }
            if (index > 0 && index <= Count)
            {
                int Count1 = Count;
                Node current = Head;
                for (int i = 0; i <= index; i++)
                {
                    current = current.Next;
                    if (i == index)
                    {
                        newNode.Next = current;
                        Count++;
                        Console.WriteLine("New Person");
                        
                    }
                }
                if (Count > Count1)
                {
                    current = Head;
                    for (int x = 0; x < index; x++)
                    {
                        current = current.Next;
                        if (x==(index-1))
                        {
                            current.Next = newNode;
                            
                        }
                    }
                }
                return false;
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
