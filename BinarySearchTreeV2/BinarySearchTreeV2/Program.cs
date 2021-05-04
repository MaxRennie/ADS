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
            BinSearchTree.Add(2);
            BinSearchTree.Add(9);
            BinSearchTree.Add(87);
            BinSearchTree.Add(23);
            BinSearchTree.Add(44);
            BinSearchTree.Add(99);
            BinSearchTree.Add(12);
            Console.WriteLine(BinSearchTree.Search(12));
            Console.WriteLine(BinSearchTree.Search(97));
        }

        public class BinarySearchTree<T> where T : IComparable
        {
            NodeBST<T> Root;
            public void Add(T itemToAdd)
            {
                NodeBST<T> NewNode = new NodeBST<T>();
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
            public void CompareAndPlace(NodeBST<T> NodeToCompareTo, NodeBST<T> NodeToPlace)
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
            public bool SearchWithNode(int ItemToFind, NodeBST<T> NodeToCompare)
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

        public class NodeBST<T> where T: IComparable
        {
            public T Data;
            public NodeBST<T> LeftChildRef;
            public NodeBST<T> RightChildRef;
        }

    }
}

