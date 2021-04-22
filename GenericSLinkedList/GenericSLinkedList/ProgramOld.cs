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
            //StringSList.RemoveLast();

            StringSList.Print();
            Console.ReadLine();
        }

        public class GenericSLinkedList<T>
        {
            public int Count;
            Node<T> Head; //defines top of list
            Node<T> End; //defines end of list
            Node<T> Current;
            Node<T> TempNode; //declare a temporary node to hold new end node

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

            //public void insert
            //{

            //}

            public void Remove(T itemToRemove)
            {
                //Node<T> matchCheckLoop(Node<T> Current, Node<T> End)
                //{
                //    if (Current.Data.Equals(itemToRemove))
                //        return Current;
                //    else
                //        return matchCheckLoop(Current.NextNodeRef, End);
                //}

                Current.NextNodeRef = TempNode;
                Current = null;
                TempNode = Current;
            }
            public void RemoveLast()
            {
                Node<T> TempNode = LoopThrough(Head, End);
                //Node<T> LoopThrough = TempNode; //find second from last element and set to TempNode

                TempNode.NextNodeRef = null; //Remove last element
                End = TempNode; //set old second from last element to new last element


                Count--;

            }

            void MoveUp


            public void Print()
            {
                Node<T> TempHead = Head;
                while (TempHead != null)
                {
                    Console.WriteLine(TempHead.Data);
                    TempHead = TempHead.NextNodeRef;
                    Console.ReadLine();
                }

            }

            Node<T> LoopThrough(Node<T> Current, T itemToRemove)
            {
                {
                    if (Current.Data.Equals(itemToRemove))
                        //if (Current.NextNodeRef == End)
                        return Current;
                    else
                        return LoopThrough(Current.NextNodeRef, End);
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
