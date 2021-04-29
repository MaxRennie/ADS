using System;

namespace GenericDLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDLinkedList<string> StringDList = new GenericDLinkedList<string>();
            StringDList.Add("Google Pixel 4");
            StringDList.Add("iPhone 6");
            StringDList.Add("iPhone X");
            StringDList.Add("Huawei Psmart 2019");
            StringDList.Add("OnePlus");

            StringDList.Print();
            Console.ReadLine();

            //StringDList.Insert("iPhone 7", 2);

            //StringDList.Print();
            //Console.ReadLine();

            //StringDList.Remove("iPhone 7");

            //StringDList.Print();
            //Console.ReadLine();

            //StringDList.RemoveLast();

            //StringDList.Print();
            //Console.ReadLine();

            StringDList.MoveUp(3);

            StringDList.Print();
            Console.ReadLine();

            StringDList.MoveDown(2);

            StringDList.Print();
            Console.ReadLine();
        }

        public class GenericDLinkedList<T>
        {
            public int Count;
            Node<T> Head; //defines top of list
            Node<T> End; //defines end of list
            //Node<T> TempNode; //declare a temporary node to hold new end node

            public void Add(T ItemToAdd)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToAdd; //Doesn't store data - see line ...

                if (End != null)//As long as end is not empty - execute line 35 -- ensures that new nodes are added to the end of the list
                {
                    End.NextNodeRef = NewNode; //see ln54, points the penultimate node to the New node
                    NewNode.PrevNodeRef = End;
                }
                //asasign prev node ref

                if (Head == null) //If there is nothing stored as data
                    Head = NewNode;

                End = NewNode;

                Count++;
            }

            public void Insert(T ItemToAdd, int index)
            {
                Node<T> NewNode = new Node<T>();
                NewNode.Data = ItemToAdd;

                Node<T> NodeToMoveDown = LoopThroughFindNodeAtIndex(Head, index);
                Node<T> ParentNode = NodeToMoveDown.PrevNodeRef;

                NewNode.NextNodeRef = NodeToMoveDown;
                NewNode.PrevNodeRef = ParentNode;
                NodeToMoveDown.PrevNodeRef = NewNode;
                ParentNode.NextNodeRef = NewNode;

                Count++;
            }
            public T Remove(T ItemToRemove)
            {
                Node<T> NodeToRemove = LoopThroughToFindNodeToRemove(Head, ItemToRemove);

                if (NodeToRemove != null)
                {
                    Node<T> ParentNode = NodeToRemove.PrevNodeRef;
                    Node<T> ChildNode = NodeToRemove.NextNodeRef;
                    ParentNode.NextNodeRef = ChildNode;
                    ChildNode.PrevNodeRef = ParentNode;

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
                T val = End.Data;
                End = End.PrevNodeRef;
                End.NextNodeRef = null;
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
                if(NodeToMoveUp == Head)
                { 
                    throw new Exception("Index is out of bounds.");
                }
                if(NodeToMoveUp == Head.NextNodeRef)
                {
                    Node<T> ParentNode = NodeToMoveUp.PrevNodeRef;
                    Node<T> ChildOfNode = NodeToMoveUp.NextNodeRef;
                    

                    Head = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }
                if(index == Count)
                {
                    Node<T> ParentNode = NodeToMoveUp.PrevNodeRef;
                    Node<T> ParentOfParentNode = ParentNode.PrevNodeRef;

                    ParentOfParentNode.NextNodeRef = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    End = ParentNode;
                }
                if (NodeToMoveUp != Head && NodeToMoveUp != Head.NextNodeRef)
                {
                    //in {0, 1, 2, 3, 4} move Up index 2 so that {0, 2, 1, 3, 4}

                    Node<T> ParentNode = NodeToMoveUp.PrevNodeRef; //assigning 1 to parent node
                    Node<T> ChildOfNode = NodeToMoveUp.NextNodeRef; // assigning 3 to child node
                    Node<T> ParentOfParentNode = ParentNode.PrevNodeRef; // assigning 0 to parent of parent

                    NodeToMoveUp.PrevNodeRef = ParentOfParentNode;//Old parent of parent (0) is now the parent of node to move up(2)      0 is now parent of 2 
                    ParentOfParentNode.NextNodeRef = NodeToMoveUp; //nodetomoveup(2) is now the child of parentof parent(0)               2 now child of 0
                    NodeToMoveUp.NextNodeRef = ParentNode;//Old parent Node(1) is now the next node/child of the node to move up(2)       1 is now child of 2
                    ParentNode.NextNodeRef = ChildOfNode;//old parent(1) is now the pareent of Child node(3)                              1 is now parent of 3
                }
            }
            public void MoveDown(int index)
            {
                Node<T> NodeToMoveDown = LoopThroughFindNodeAtIndex(Head, index);

                if (index >= Count) 
                {
                    throw new Exception("Index is out of bounds.");
                }

                if (index == (Count-1)) //if End
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
                    Node<T> ParentNode = NodeToMoveDown.PrevNodeRef;
                    Node<T> ChildOfNode = NodeToMoveDown.NextNodeRef;
                    Node<T> ChildOfChildNode = ChildOfNode.NextNodeRef;

                    ChildOfNode.NextNodeRef = NodeToMoveDown;
                    NodeToMoveDown.NextNodeRef = ChildOfChildNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }

                
                if (index == (Count-2))//if penultimate node
                {
                    Node<T> ParentNode = NodeToMoveDown.PrevNodeRef;
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

            Node<T> LoopThroughToFindNodeToRemove(Node<T> Current, T itemToRemove)
            {
                if (Current.NextNodeRef != null)
                {
                    if (Current.Data != null && Current.Data.Equals(itemToRemove))
                        return Current;
                    else
                    {
                        return LoopThroughToFindNodeToRemove(Current.NextNodeRef, itemToRemove);
                    }
                }
                else
                    return null;
            }

            Node<T> LoopThroughToFindParentOfItem(Node<T> Current, T itemToRemove)
            {
                if (Current.NextNodeRef != null)
                {
                    if (Current.NextNodeRef.Data != null && Current.NextNodeRef.Data.Equals(itemToRemove))
                        return Current;
                    else
                    {
                        return LoopThroughToFindParentOfItem(Current.NextNodeRef, itemToRemove);
                    }
                }
                else
                    return null;
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
                public Node<T> PrevNodeRef;
                public T Data;
                public Node<T> NextNodeRef; //nextnoderef references another node "somewhere" in the memory
            }
        }
    }
}
