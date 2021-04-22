using System;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---GENERIC STACK---");
            genericStack();
        }

        static void genericStack()
        {
            Stack<string> stringStack = new Stack<string>();
            Stack<int> integerStack = new Stack<int>();

            Console.WriteLine("Enqueue strings and print");
            stringStack.EnqueuePush("Learn C# in 24 hours");
            stringStack.EnqueuePush("Yellow Duck book");
            stringStack.EnqueuePush("The Anti-aging Cookbook");
            stringStack.EnqueuePush("Simple Stargazing");
            stringStack.EnqueuePush("Mexican Cooking");
            Console.WriteLine();

            stringStack.Print();
            Console.ReadLine();

            stringStack.EnqueuePush("The Key to Deep Work");
            stringStack.Print();
            Console.ReadLine();

            stringStack.DequeuePop();
            Console.WriteLine("String Dequeued");
            Console.ReadLine();

            stringStack.Print();
            Console.ReadLine();

            Console.WriteLine("Enqueue integers and print");
            integerStack.EnqueuePush(22);
            integerStack.EnqueuePush(84);
            integerStack.EnqueuePush(41);
            integerStack.EnqueuePush(48);
            integerStack.EnqueuePush(1);

            integerStack.Print();
            Console.ReadLine();

            integerStack.DequeuePop();
            Console.WriteLine("Integer Dequeued");
            Console.ReadLine();

            integerStack.Print();
            Console.ReadLine();
        }

        class Stack<T>
        {
            private int TopElement = 0;
            public T[] stackPile = new T[10];

            public void EnqueuePush(T NewItem)
            {
                stackPile[TopElement] = NewItem;
                TopElement++;

                if (stackPile.Length == TopElement)
                {
                    //make stack bigger
                    T[] temp = new T[stackPile.Length + 1];
                    for (int i = 0; i < stackPile.Length; i++)
                    {
                        temp[i] = stackPile[i];
                    }
                    stackPile = temp;
                }
            }

            public T DequeuePop()
            {
                TopElement--;
                T TempReturnVal = stackPile[TopElement]; // 
                stackPile[TopElement] = default; // identifies top element
                return TempReturnVal; //return removes the top element
            }

            public void Print()
            {
                foreach (T stackItem in stackPile)
                {
                    if (stackItem != null)
                        Console.WriteLine(stackItem);
                }
            }
        }

        class Node<T>
        {
            public Node<T> stackNode;
            public T data;
        }

    }
}