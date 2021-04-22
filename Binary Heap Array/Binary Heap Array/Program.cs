using System;

namespace Binary_Heap_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap();
            Console.ReadLine(); 
        }

        private static void PrintArr(int[] values)
        {
            foreach (int i in values)
            {
                Console.Write(i + ", ");
            }
        }

        public static void MinHeap()
        {
            BinaryMinimumHeap<int> IntMinHeap = new BinaryMinimumHeap<int>();
            IntMinHeap.Add(7);
            IntMinHeap.Add(2);
            IntMinHeap.Add(6);
            IntMinHeap.Add(9);
            IntMinHeap.Add(1);
            IntMinHeap.Add(8);
            IntMinHeap.Add(7);

            IntMinHeap.Extract(7);
            IntMinHeap.Extract(1);
            IntMinHeap.Extract(9);

        }

        public class BinaryMinimumHeap<T>
        {
            public int count;
            Node<T> RootNode;

            public void Add(T ItemToAdd)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToAdd;
                NewNode.NodeCount = count;
                Node<T> FreeNode = new Node<T>();

                if (count == 0) //if first node
                {
                    RootNode = NewNode;//create node
                    RootNode.Data = ItemToAdd;
                }
                else//add node in as child of respective node
                {
                    NewNode = FindFreeChildNode(RootNode);
                    NewNode.Data = ItemToAdd;
                }

                CompareToParent(NewNode);
                count++;
            }
            public void Extract(T ItemToRemove)
            {

            }




            Node<T> FindParentNode;

            public void CompareToParent(Node<T> NodeToCompare)
            {
                if ()//new node is > parent node
                {
                    SwapValues(NodeToCompare, ParentNode)
                }
            }

            public static void SwapValues(Node<T> Greater, Node<T> Lesser)
            {
                Node<T> temp;
                temp = Greater;
                Greater = Lesser;
                Lesser = temp;
            }

            class Node<T>
            {
                public Node<T> LeftChild;
                public Node<T> RightChild;
                public Node<T> ChildOf;

                public Node<T> PrevNodeRef;
                public T Data;
                public Node<T> NextNodeRef;
                public int NodeCount;
            }
        }
    }
}
