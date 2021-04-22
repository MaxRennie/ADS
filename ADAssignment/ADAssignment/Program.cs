using System;
using System.Collections.Generic;

namespace ADAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---GENERIC STACK---");
            genericStack();
            Console.ReadLine();

            Console.WriteLine("---GENERIC QUEUE---");
            genericQueue();
            Console.ReadLine();

            Console.WriteLine("---GENERIC SINGLY LINKED LIST---");
            singlyLinkedList();
            Console.ReadLine();

            Console.WriteLine("---GENERIC DOUBLY LINKED LIST---");
            doublyLinkedList();
            Console.ReadLine();

            Console.WriteLine("---QUICK SORT---");
            quickSort();
            Console.ReadLine();

            Console.WriteLine("---BUBBLE SORT---");
            bubbleSort();
            Console.ReadLine();

            Console.WriteLine("---INSERTION SORT---");
            insertionSortArray();
            Console.ReadLine();

            Console.WriteLine("---RADIX SORT---");
            radixSort();
            Console.ReadLine();

            Console.WriteLine("---BINARY SEARCH---");
            BinarySearch();
            Console.ReadLine();
        }


        static void genericStack()
        { 
        Stack <string> stringStack = new Stack <string> ();
        Stack <int> integerStack = new Stack <int>();

            Console.WriteLine("--Enqueue strings and print--");
            stringStack.EnqueuePush("Learn C# in 24 hours");
            stringStack.EnqueuePush("Yellow Duck book");
            stringStack.EnqueuePush("The Anti-aging Cookbook");
            stringStack.EnqueuePush("Simple Stargazing");
            stringStack.EnqueuePush("Mexican Cooking");
               
            stringStack.Print();
            Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("--String Dequeued--");
            stringStack.DequeuePop();
            stringStack.Print();
            Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("--Enqueue strings and print--");
            integerStack.EnqueuePush(22);
            integerStack.EnqueuePush(84);
            integerStack.EnqueuePush(41);
            integerStack.EnqueuePush(48);
            integerStack.EnqueuePush(1);
            integerStack.Print();
            Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("--Item Dequeued--");
            integerStack.DequeuePop();
            // Console.ReadLine();

            integerStack.Print();
            Console.ReadLine();
        }
        static void genericQueue()
        {
            Queue<string> stringQueue = new Queue<string>();
            Queue<int> integerQueue = new Queue<int>();

            Console.WriteLine("--Enqueue strings and print--");
            stringQueue.Enqueue("Learn C# in 24 hours");
            stringQueue.Enqueue("Yellow Duck book");
            stringQueue.Enqueue("The Anti-aging Cookbook");
            stringQueue.Enqueue("Simple Stargazing");
            stringQueue.Enqueue("Mexican Cooking");
            stringQueue.Print();
            Console.WriteLine();

            Console.WriteLine("--Enqueue 1 string--");
            stringQueue.Enqueue("The Key to Deep Work");
            stringQueue.Print();
            Console.WriteLine();

            stringQueue.Dequeue();
            Console.WriteLine("--String Dequeued--");
            stringQueue.Print();
            Console.WriteLine();

            Console.WriteLine("--Enqueue strings and print--");
            integerQueue.Enqueue(22);
            integerQueue.Enqueue(84);
            integerQueue.Enqueue(41);
            integerQueue.Enqueue(48);
            integerQueue.Enqueue(1);
            integerQueue.Print();
            Console.WriteLine();

            integerQueue.Dequeue();
            Console.WriteLine("--Item Dequeued--");
            integerQueue.Print();
            Console.WriteLine();
        }
        static void singlyLinkedList()
        {
            GenericSLinkedList<string> StringSList = new GenericSLinkedList<string>();
            Console.WriteLine("--Initialise and add 4 items to SLL--");
            StringSList.Add("Google Pixel 4");
            StringSList.Add("iPhone 6");
            StringSList.Add("iPhone X");
            StringSList.Add("Huawei Psmart 2019");

            StringSList.Print();
            Console.WriteLine();


            Console.WriteLine("--Remove last and iPhone X--");
            StringSList.Remove("iPhone X");
            StringSList.RemoveLast();
            StringSList.Print();
            Console.WriteLine();


            Console.WriteLine("--Add Huawei Psmart 2019 and iPhone X--");
            StringSList.Add("iPhone X");
            StringSList.Add("Huawei Psmart 2019");
            StringSList.Print();
            Console.WriteLine();


            Console.WriteLine("--Insert Samsung Galaxy into index 2--");
            StringSList.insert("Samsung Galaxy", 2);

            StringSList.Print();
            Console.WriteLine();


            Console.WriteLine("--Move item in index 3 Up--"); 
            StringSList.MoveUp(3);

            StringSList.Print();
            Console.WriteLine();


            Console.WriteLine("--Move iPhone X Down--");
            StringSList.MoveDown(2);


            StringSList.Print();
            Console.WriteLine();

        }
        static void doublyLinkedList()
        {
            GenericDLinkedList<string> StringDList = new GenericDLinkedList<string>();
            Console.WriteLine("--Initialize DLL and add 5 items--");
            StringDList.Add("Google Pixel 4");
            StringDList.Add("iPhone 6");
            StringDList.Add("iPhone X");
            StringDList.Add("Huawei Psmart 2019");
            StringDList.Add("OnePlus");
            StringDList.Print();
            Console.WriteLine();

            Console.WriteLine("--Insert Iphone 7 into index 2--");
            StringDList.Insert("iPhone 7", 2);
            StringDList.Print();
            Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("--Remove iPhone 7--");
            StringDList.Remove("iPhone 7");
            StringDList.Print();
            Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("--Remove last item of list--");
            StringDList.RemoveLast();

            StringDList.Print();
            Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("--Move item in index 3 up one space--");
            StringDList.MoveUp(3);
            StringDList.Print();
            Console.WriteLine();


            Console.WriteLine("--Move item in index 2 down one space--");
            StringDList.MoveDown(2);
            StringDList.Print();
            Console.ReadLine();
        }
        private static void quickSort()
        {
            int[] values = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7, 6 };
            PrintArray(values);
            Console.WriteLine();
            QuickSortArray(values);
            PrintArray(values);
            Console.WriteLine();
            Console.ReadLine();
        }
        private static void bubbleSort()
        {
            int[] values = new[] { 4, 16, 29, 28, 12, 8, 10, 20, 1, 19, 8, 16 };
            PrintArray(values);
            Console.WriteLine();
            bubbleSortArray(values);
            PrintArray(values);
            Console.WriteLine();
            Console.ReadLine();

        }
        static void insertionSortArray()
        {
            int[] values = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7 };

            PrintArray(values);
            Console.WriteLine();

            PrintArray(insertionSort(values));
            Console.WriteLine();
            Console.ReadLine();
        }
        static void radixSort()
        {
            int[] values = new int[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7 };
            PrintArray(values);
            Console.WriteLine();
            PrintRadixSortedArray(RadixSort(values));
            Console.WriteLine();
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

            //public void Print()
            //{
            //    foreach (T stackItem in stackPile)
            //    {
            //        if(stackItem != null)
            //        Console.WriteLine(stackItem);
            //    }
            //}

            public void Print()
            {
                int i= 0;
                foreach (T stackItem in stackPile)
                {
                    if (i < TopElement && stackItem != null)
                    {
                        Console.WriteLine(stackItem);
                    }
                    i++;   
                }
            }
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
                int i = 0;
                foreach (T queueItem in queuePile)
                {
                    if (i < TopCount && queueItem != null)
                    {
                        Console.WriteLine(queueItem);
                    }
                    i++;
                }
            }
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
                if (NodeToMoveUp == Head)
                {
                    throw new Exception("Index is out of bounds.");
                }
                if (NodeToMoveUp == Head.NextNodeRef)
                {
                    Node<T> ParentNode = NodeToMoveUp.PrevNodeRef;
                    Node<T> ChildOfNode = NodeToMoveUp.NextNodeRef;

                    Head = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }
                if (index == Count)
                {
                    Node<T> ParentNode = NodeToMoveUp.PrevNodeRef;
                    Node<T> ParentOfParentNode = ParentNode.PrevNodeRef;

                    ParentOfParentNode.NextNodeRef = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    End = ParentNode;
                }
                if (NodeToMoveUp != Head && NodeToMoveUp != Head.NextNodeRef)
                {
                    Node<T> ParentNode = NodeToMoveUp.PrevNodeRef;
                    Node<T> ChildOfNode = NodeToMoveUp.NextNodeRef;
                    Node<T> ParentOfParentNode = ParentNode.PrevNodeRef;
                    
                    ParentOfParentNode.NextNodeRef = NodeToMoveUp;
                    NodeToMoveUp.NextNodeRef = ParentNode;
                    NodeToMoveUp.PrevNodeRef = ParentOfParentNode;
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
                    Node<T> ParentNode = NodeToMoveDown.PrevNodeRef;
                    Node<T> ChildOfNode = NodeToMoveDown.NextNodeRef;
                    Node<T> ChildOfChildNode = ChildOfNode.NextNodeRef;

                    ChildOfNode.NextNodeRef = NodeToMoveDown;
                    NodeToMoveDown.NextNodeRef = ChildOfChildNode;
                    ParentNode.NextNodeRef = ChildOfNode;
                }


                if (index == (Count - 2))//if penultimate node
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
        public static void PrintArray(int[] source)
        {
            foreach (int i in source)
            {
                Console.Write(i + ", ");
            }
        }
        public static void QuickSortArray(int[] values)
        {
            QuickSort(values, 0, values.Length - 1);
        }
        private static void QuickSort(int[] values, int LoIndex, int HiIndex)
        {
            int i = LoIndex;
            int j = HiIndex;
            int pivot = values[(LoIndex + HiIndex) / 2];

            while (i <= j)
            {
                while (values[i] < pivot)
                    i++;
                while (values[j] > pivot)
                    j--;

                if (i <= j)
                {
                    SwapValues(values, i, j);
                    i++;
                    j--;
                }
                if (LoIndex < j)
                    QuickSort(values, LoIndex, j);
                if (i < HiIndex)
                    QuickSort(values, i, HiIndex);
            }
        }
        public static void SwapValues(int[] source, int index1, int index2)
        {
            //reference -- https://stackoverflow.com/questions/43759043/how-can-i-swap-two-values-of-an-array-in-c
            int temp;
            temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }
        private static void bubbleSortArray(int[] unsortedData)
        {
            foreach (int item in unsortedData)
            {
                for (int i = 0; i < unsortedData.Length - 1; i++)
                {
                    if (unsortedData[i] > unsortedData[i + 1])
                    {
                        SwapValues(unsortedData, i, i + 1);
                    }
                }
            }
        }
        public static int[] insertionSort(int[] unsortedData)
        {
            for (int i = 0; i < unsortedData.Length; i++)
            {
                int j = i;
                while (j > 0 && unsortedData[j - 1] > unsortedData[j])
                {
                    SwapValues(unsortedData, j - 1, j);
                    j--;
                }
            }
            return unsortedData;
        }
        static int[] RadixSort(int[] unsortedData)
        {
            List<int>[] Buckets = new List<int>[10];
            int Columns = 1;

            do
            {
                for (int i = 0; i < Buckets.Length; i++)
                {
                    Buckets[i] = new List<int>();
                }

                foreach (int Element in unsortedData)
                {
                    int BucketIndex = GetPlaces(Element, Columns);
                    Buckets[BucketIndex].Add(Element);

                }


                unsortedData = new int[unsortedData.Length];
                int index = 0;
                foreach (List<int> bucket in Buckets)
                {
                    foreach (int element in bucket)
                    {
                        unsortedData[index] = element;
                        index++;
                    }
                }

                Columns *= 10;

            } while (Buckets[0].Count != unsortedData.Length);
            return unsortedData;
        }
        static int GetPlaces(int value, int places)
        {
            return ((value % (places * 10)) - (value % places)) / places;
        }
        public static void PrintRadixSortedArray(int[] source)
        {
            foreach (int i in source)
            {
                Console.Write(i.ToString() + ", ");
            }
        }
        static void BinarySearch()
        {
            List<int> Data = new List<int>();
            Data.Add(54);
            Data.Add(58);
            Data.Add(69);
            Data.Add(72);
            Data.Add(35);
            Data.Add(4);
            Data.Add(16);
            Data.Add(95);

            Data.ForEach(Console.WriteLine);

            Console.WriteLine("Is 16 in the list? " + search(Data, 16));
            Console.WriteLine("Is 643 in the list? " + search(Data, 643));
            Console.ReadLine();
        }
        static bool search(List<int> data, int searchItem)
        {
            bool result = false;
            data.Sort();
            int mid = data.Count / 2;
            if (mid == default)
            {
                return result;
            }
            if (data[mid] == searchItem)
            {
                //Found!!
                result = true;
            }
            else if (searchItem > data[mid])
            {
                //right side, upper segment
                List<int> subData = data;
                subData.RemoveRange(0, mid);
                result = search(subData, searchItem);
            }
            else if (searchItem < data[mid])
            {
                //left side, lower segment
                List<int> subData = data;
                subData.RemoveRange(mid, mid);
                result = search(subData, searchItem);
            }
            return result;
        }
        class Node<T>
        {
            public Node<T> stackNode;
            public T Data;
            public Node<T> NextNodeRef;
            public Node<T> PrevNodeRef;
        }

    }
}
