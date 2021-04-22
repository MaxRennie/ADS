using System;

namespace BinarySearchTreeV2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinSearchTree();
            Console.ReadLine();
        }

        public static void BinSearchTree()
        {
            BinarySearchTree<int> BinSearchTree = new BinarySearchTree<int>();
            BinSearchTree.Add(64);
            Console.WriteLine();
            BinSearchTree.Add(2);
            Console.WriteLine();
            BinSearchTree.Add(9);
            Console.WriteLine();
            BinSearchTree.Add(87);
            Console.WriteLine();
            BinSearchTree.Add(23);
            Console.WriteLine();
            BinSearchTree.Add(44);
            Console.WriteLine();
            BinSearchTree.Add(99);
            Console.WriteLine();
            BinSearchTree.Add(12);
            Console.WriteLine();
            Console.WriteLine(BinSearchTree.Search(12));
            Console.WriteLine(BinSearchTree.Search(97));
            Console.ReadLine();

        }

        public class BinarySearchTree<T> where T : IComparable
        {
            Node<T> Root;
            public void Add(T itemToAdd)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = itemToAdd;

                if (Root == null)
                {
                    Root = NewNode;
                }
                else
                {
                    CompareAndPlace(Root, NewNode);
                }
            }
            public void CompareAndPlace(Node<T> NodeToCompareTo, Node<T> NodeToPlace)
            {
                if (NodeToPlace.Data.CompareTo(NodeToCompareTo.Data) >=0)
                {
                    if(NodeToCompareTo.LeftChildRef == null)
                    {
                        NodeToCompareTo.LeftChildRef = NodeToPlace;
                    }
                    else
                    {
                        CompareAndPlace(NodeToCompareTo.LeftChildRef, NodeToPlace);
                    }
                }
                if (NodeToPlace.Data.CompareTo(NodeToCompareTo.Data) <= 0)
                {
                    if (NodeToCompareTo.RightChildRef == null)
                    {
                        NodeToCompareTo.RightChildRef = NodeToPlace;
                    }
                    else
                    {
                        CompareAndPlace(NodeToCompareTo.RightChildRef, NodeToPlace);
                    }
                }
            }
            public bool Search(int itemToFind) {
                bool result = SearchWithNode(itemToFind, Root);
                return result;
            }
            public bool SearchWithNode(int ItemToFind, Node<T> NodeToCompare)
            {
                while (NodeToCompare != null)
                {
                    if (ItemToFind.CompareTo(NodeToCompare.Data) > 0)
                    {
                        NodeToCompare = NodeToCompare.LeftChildRef;
                    }
                    else if (ItemToFind.CompareTo(NodeToCompare.Data) < 0)
                    {
                        NodeToCompare = NodeToCompare.RightChildRef;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public class Node<T> where T: IComparable
        {
            public T Data;
            public Node<T> LeftChildRef;
            public Node<T> RightChildRef;
        }

    }
}

