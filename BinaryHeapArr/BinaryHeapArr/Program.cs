using System;


namespace BinaryHeapArr
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap();
            Console.ReadLine();
        }

        private static void MinHeap()
        {
            BinaryMinHeap<int> MinHeapClass = new BinaryMinHeap<int>();
            MinHeapClass.Add(7);
            //MinHeapClass.Add(2);
            //MinHeapClass.Add(6);
            //MinHeapClass.Add(9);
            //MinHeapClass.Add(1);
            //MinHeapClass.Add(8);
            //MinHeapClass.Add(7);

            //MinHeapClass.Extract(7);
            //MinHeapClass.Extract(1);
            //MinHeapClass.Extract(9);

            MinHeapClass.Print();
        }


        class BinaryMinHeap<T>
        {
            Node<T> RootNode = new Node<T>();
            Node<T> CurrentNode = new Node<T>();

            public void Add(T ItemToAdd)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToAdd;

                int count = 0;
                if (count == 0)
                {
                    RootNode = NewNode;
                    RootNode.Data = ItemToAdd;
                    RootNode.LeftChild = null;
                    RootNode.RightChild = null;
                    RootNode = CurrentNode;
                }
                else
                {
                    NewNode = FindFreeChildNode(RootNode);
                    NewNode.Data = ItemToAdd;
                }
            }

            public void Extract(int ItemToAdd)
            {
                throw new NotImplementedException();
            }

            internal void Print()
            {
                if (CurrentNode.LeftChild != null || CurrentNode.RightChild != null)
                {
                    if (CurrentNode.LeftChild == null)
                    {
                        return CurrentNode.LeftChild;
                    }
                    else if (CurrentNode.RightChild == null)
                    {
                        return CurrentNode.RightChild;
                    }
                    else if (FindFreeChildNode(CurrentNode.LeftChild) == null)
                    {
                        return FindFreeChildNode(CurrentNode.LeftChild);
                    }
                    else if (FindFreeChildNode(CurrentNode.RightChild) == null)
                    {
                        return FindFreeChildNode(CurrentNode.RightChild);
                    }
                }
                return null;
            }

            Node<T> FindFreeChildNode(Node<T> CurrentNode)
            {
                if (CurrentNode.LeftChild != null || CurrentNode.RightChild != null)
                {
                    if (CurrentNode.LeftChild == null)
                    {
                        return CurrentNode.LeftChild;
                    }
                    else if (CurrentNode.RightChild == null)
                    {
                        return CurrentNode.RightChild;
                    }
                    else if (FindFreeChildNode(CurrentNode.LeftChild) == null)
                    {
                        return FindFreeChildNode(CurrentNode.LeftChild);
                    }
                    else if (FindFreeChildNode(CurrentNode.RightChild) == null)
                    {
                        return FindFreeChildNode(CurrentNode.RightChild);
                    }
                }
                return null;
            }

            

            class Node<T>
            {
                public Node<T> ParentNode;
                public Node<T> LeftChild;
                public Node<T> RightChild;
                public T Data;
                public T NodeCount;
            }
        }
    }
}
