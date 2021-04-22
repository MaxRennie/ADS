using System;

namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---GENERIC QUEUE---");
            genericQueue();
        }

        static void genericQueue()
        {
            Queue<string> stringQueue = new Queue<string>();
            Queue<int> integerQueue = new Queue<int>();

            Console.WriteLine("Enqueue strings and print");
            stringQueue.Enqueue("Learn C# in 24 hours");
            stringQueue.Enqueue("Yellow Duck book");
            stringQueue.Enqueue("The Anti-aging Cookbook");
            stringQueue.Enqueue("Simple Stargazing");
            stringQueue.Enqueue("Mexican Cooking");
            Console.WriteLine();
            stringQueue.Print();
            Console.ReadLine();

            Console.WriteLine("Enqueue 1 string");
            stringQueue.Enqueue("The Key to Deep Work");
            stringQueue.Print();
            Console.ReadLine();

            stringQueue.Dequeue();
            Console.WriteLine("String Dequeued");
            Console.ReadLine();

            stringQueue.Print();
            Console.ReadLine();

            Console.WriteLine("Enqueue strings and print");
            integerQueue.Enqueue(22);
            integerQueue.Enqueue(84);
            integerQueue.Enqueue(41);
            integerQueue.Enqueue(48);
            integerQueue.Enqueue(1);

            integerQueue.Print();
            Console.ReadLine();

            integerQueue.Dequeue();
            Console.WriteLine("Item Dequeued");
            Console.ReadLine();

            integerQueue.Print();
            Console.ReadLine();
        }

        class Queue<T>
        {
            public int TopCount = 0;
            public int BottomCount = 0;
            //public Node<T> Head; //defines top of list
            //public Node<T> End; //defines end of list
            public T[] queuePile = new T[1];

            public void Enqueue(T NewItem)
            {
                queuePile[TopCount] = NewItem; //insert new item in the next slot of array
                TopCount++; //increase count when item added


                if (queuePile.Length == TopCount)
                {
                    T[] temp = new T[queuePile.Length + 1];
                    for (int i = 0; i < queuePile.Length; i++)
                    {
                        temp[i] = queuePile[i];
                    }
                    queuePile = temp;
                }
            }

            public T Dequeue()
            {
                BottomCount++;//decrease count
                T TempReturnVal = queuePile[0]; //returns item at index 0
                queuePile[BottomCount - 1] = default; // identifies top element
                return TempReturnVal; //return removes the top element
            }

            public void Print()
            {
                foreach (T queueItem in queuePile)
                {
                    if (queueItem != null)
                        Console.WriteLine(queueItem);
                }
            }
        }

        class Node<T>
        {
            public Node<T> queueNode;
            public T data;
        }

    }
}