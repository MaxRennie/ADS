using System;

namespace GenericSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericSLinkedList<string> StringSList = new GenericSLinkedList<string>();
            StringSList.Add("Google Pixel 4");
            StringSList.Add("iPhone 6");
            StringSList.Add("iPhone X");
            StringSList.Add("Huawei Psmart 2019");

            StringSList.Print();
            Console.ReadLine();

            StringSList.Remove("iPhone X");
            StringSList.RemoveLast();
            Console.WriteLine("Remove last and iPhone X");

            StringSList.Print();
            Console.ReadLine();

            StringSList.Add("iPhone X");
            StringSList.Add("Huawei Psmart 2019");
            Console.WriteLine("Add Huawei Psmart 2019 and iPhone X");

            StringSList.Print();
            Console.ReadLine();

            StringSList.insert("Samsung Galaxy", 2);
            Console.WriteLine("Insert Samsung Galaxy at index 2");

            StringSList.Print();
            Console.ReadLine();

            StringSList.MoveUp(3);
            Console.WriteLine("Move iPhone X Up");


            StringSList.Print();
            Console.ReadLine();

            StringSList.MoveDown(2);
            Console.WriteLine("Move iPhone X Down");


            StringSList.Print();
            Console.ReadLine();
        }

        public class GenericSLinkedList<T>
        {
            public int Count;
            Node<T> Head; //defines top of list
            Node<T> End; //defines end of list
            //Node<T> TempNode; //declare a temporary node to hold new end node

            public void Add(T ItemToAdd)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToAdd; //Doesn't store data - see line ...

                if (End != null) //As long as end is not empty - execute line 35 -- ensures that new nodes are added to the end of the list
                    End.NextNodeRef = NewNode; //see ln54, points the penultimate node to the New node

                if (Head == null) //If there is nothing stored as data
                    Head = NewNode;

                End = NewNode;

                Count++;

            }

            public void insert(T ItemToInsert, int index)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToInsert; //Doesn't store data - see line ...

                Node<T> NodeToMoveDown = LoopThroughFindNodeAtIndex(Head, index);
                Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, NodeToMoveDown);

                NewNode.NextNodeRef = NodeToMoveDown;
                ParentNode.NextNodeRef = NewNode;

                Count++;
            }

            public T Remove(T itemToRemove)
            {
                Node<T> TempParentNodeNode = LoopThroughToFindParentOfItem(Head, itemToRemove);

                if (TempParentNodeNode != null)
                {
                    Node<T> NodeToRemove = TempParentNodeNode.NextNodeRef;

                    TempParentNodeNode.NextNodeRef = NodeToRemove.NextNodeRef;

                    T val = NodeToRemove.Data;
                    NodeToRemove = null;
                    Count--;


                    return val;
                }
                else
                {
                    return default;
                }
            }

            public T RemoveLast()
            {

                Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, End); //LoopThroughToFindItem(Head, End.Data);
                //Node<T> LoopThrough = TempNode; //find second from last element and set to TempNode

                T val = End.Data;

                End = ParentNode; //set old second from last element to new last element
                End.NextNodeRef = null; //Remove last element

                Count--;

                return val;
            }

            public void MoveUp(int index)
            {
                if (index >= Count)
                {
                    throw new Exception("Index is out of bounds.");
                }

                Node<T> NodeToMoveUp = LoopThroughFindNodeAtIndex(Head, index);
                
                if (NodeToMoveUp == Head)
                {
                    throw new Exception("Index is out of bounds.");
                }

                if (NodeToMoveUp == Head.NextNodeRef)
                {
                    Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, NodeToMoveUp);
                    Node<T> ChildOfNode = NodeToMoveUp.NextNodeRef;


                    Head = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }
                if (index == Count)
                {
                    Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, NodeToMoveUp);
                    Node<T> ParentOfParentNode = LoopThroughToFindParentOfNode(Head, ParentNode);

                    ParentOfParentNode.NextNodeRef = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    End = ParentNode;
                }
                if (NodeToMoveUp != Head && NodeToMoveUp != Head.NextNodeRef)
                {
                    Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, NodeToMoveUp);
                    Node<T> ParentOfParentNode = LoopThroughToFindParentOfNode(Head, ParentNode);
                    Node<T> ChildOfNode = NodeToMoveUp.NextNodeRef;

                    ParentOfParentNode.NextNodeRef = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }
            }

            public void MoveDown(int index)
            {
                Node<T> NodeToMoveDown = LoopThroughFindNodeAtIndex(Head, index);

                if (index >= Count)
                {
                    throw new Exception("Index is out of bounds.");
                }

                if (index == (Count - 1)) //if End
                {
                    throw new Exception("Index is out of bounds.");
                }

                if (NodeToMoveDown == Head) //if Head
                {
                    Node<T> ChildOfNode = NodeToMoveDown.NextNodeRef;
                    Node<T> ChildOfChildNode = ChildOfNode.NextNodeRef;

                    Head = ChildOfNode;
                    ChildOfNode.NextNodeRef = NodeToMoveDown;
                    NodeToMoveDown.NextNodeRef = ChildOfChildNode;
                }

                if (NodeToMoveDown != Head && index != (Count - 2)) //if normal middle index
                {
                    Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, NodeToMoveDown);
                    Node<T> ChildOfNode = NodeToMoveDown.NextNodeRef;
                    Node<T> ChildOfChildNode = ChildOfNode.NextNodeRef;

                    ChildOfNode.NextNodeRef = NodeToMoveDown;
                    NodeToMoveDown.NextNodeRef = ChildOfChildNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }


                if (index == (Count - 2))//if penultimate node
                {
                    Node<T> ParentNode = LoopThroughToFindParentOfNode(Head, NodeToMoveDown);
                    Node<T> ChildOfNode = NodeToMoveDown.NextNodeRef;

                    ParentNode.NextNodeRef = ChildOfNode;
                    ChildOfNode.NextNodeRef = NodeToMoveDown;
                    End = NodeToMoveDown;
                    NodeToMoveDown.NextNodeRef = null;
                }
            }

            public void Print()
            {
                Node<T> TempHead = Head;
                while (TempHead != null)
                {
                    Console.WriteLine(TempHead.Data);
                    TempHead = TempHead.NextNodeRef;
                    //Console.ReadLine();
                }

            }

            Node<T> LoopThroughToFindParentOfItem(Node<T> Current, T itemToRemove)
            {
                if (Current.NextNodeRef != null)
                {
                    if (Current.NextNodeRef.Data != null && Current.NextNodeRef.Data.Equals(itemToRemove))
                        return Current;
                    else
                    {
                        //if (Current.NextNodeRef.Data != null)
                            return LoopThroughToFindParentOfItem(Current.NextNodeRef, itemToRemove);
                        //else
                            //return null;
                    }
                }
                else 
                    return null;
            }
            Node<T> LoopThroughToFindParentOfNode(Node<T> Current, Node<T> NodeToRemove)
            {
                if (Current.NextNodeRef.Equals(NodeToRemove))
                    return Current;
                else
                {
                    if (Current.NextNodeRef != null)
                        return LoopThroughToFindParentOfNode(Current.NextNodeRef, NodeToRemove);
                    else
                        return null;
                }
            }
            Node<T> LoopThroughFindNodeAtIndex(Node<T> Current, int Index, int depth = 0)
            {
                if (Index >= Count)
                    throw new Exception("Index is out of bounds.");
                if (depth >= Count)
                    throw new Exception("Depth is out of bounds.");
                if (depth == Index)
                {
                    return Current;
                }
                else
                {
                    return LoopThroughFindNodeAtIndex(Current.NextNodeRef, Index, ++depth);
                }
            }

            class Node<T>
            {
                public T Data;
                public Node<T> NextNodeRef; //nextnoderef references another node "somewhere" in the memory
            }
        }
    }
}
