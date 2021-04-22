using System;

namespace Binary_heap
{
    class Program
    {
        static void Main(string[] args)
        {
                
        }



        public static void MinHeap()
        {
            

            
        }
        public class BinaryMinimumHeap<T>
        {
            public int count;
            Node<T> RootNode;

            public void Add(T ItemToAdd)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToAdd;

                Node<T> FreeNode = new Node<T>();

                if (count == 0) //if first node
                {
                    RootNode = NewNode;//create node
                    RootNode.Data = ItemToAdd;
                }
                else//add node in as child of respective node
                {
                    FreeNode = FindFreeChildNode(RootNode);
                    FreeNode = NewNode;
                    FreeNode.Data = ItemToAdd;
                }

                if (NewNode)
                {

                }


                count++;
               
                
              
                
                //compare to parent nodes
                //
            }
            public void Extract()
            {

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

            public void CompareToParent(Node<T> NodeToCompare)
            {
                
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
            }
        }
    }
}
