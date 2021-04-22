using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNode
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class QuickQueue
        {
            public Node2<string> TopNode; // says i want to hold a refernce to an object

            QuickQueue()
            {
                Node2<string> newNode = new Node2<string>(); // creates a container for the data?
                TopNode = newNode;
            }
        }

        class Node2<T>
        {
            public Node2<T> NextNode; //designates the next node
            public T data; // designates where to hold data, pick a data type, in htis case generic
            
        }
    }
}
