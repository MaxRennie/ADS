using System;

namespace SingleList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleList<string> Node = new SingleList<string>();
            Node.Insert("Miss Piggy");
            Node.Insert("Kermit");
            Node.Insert("Gonzo");
            Node.Insert("Fozzie");
            Node.Insert("Scooter");
            Node.Print();
            Node.Delete("Miss Piggy");
            Node.Print();
            Node.Delete("Scooter");
            Node.Print();
            Node.Insert("Sweetums");
            Node.Print();

            Console.ReadLine();
        }
    }


    public class SingleList<T> // creates the class which holds the list
    {

        public int Count = 0;
        public SListNode<T> Head;// node to tell which node is first in the list
        public SListNode<T> End;// node to tell which is last


        public void Insert(T ItemToAdd) //creates function to insert new node (but only at the end of the list)
        {
            SListNode<T> NewNode = new SListNode<T>();
            NewNode.data = ItemToAdd;

            if (Head == null)
            { Head = NewNode; }
            if (End != null)
            { End.NextNodeRef = NewNode; }


            End = NewNode;
            Count++;
            NewNode.index = Count;

        }

        public void Delete(T ItemToDelete) //creates function to delete a node by comparing the string to an Item to 
        {
            SListNode<T> temp = Head; //new var to hold Head while comparing
            SListNode<T> prev = default; //checks what the previous item checked was (Set to generic null)
            if (!temp.data.Equals(default) && temp.data.Equals(ItemToDelete)) //if temp.data does not equal null && does equal item to delete
            {
                Head = temp.NextNodeRef; //set head to next node
                Count--;
                return;
            }
            while ((!temp.data.Equals(default)) && (!temp.data.Equals(ItemToDelete))) //while temp.data does not equal null && also does NOT equal Item to delete
            {

                prev = temp; // set previous var into temp (ie, we knw what we just checked)
                temp = temp.NextNodeRef; // this now moves onto check the next item in the list until it finds a match
            }

            if (temp == default) // 
            {
                End = prev;
                return;
            }
            prev.NextNodeRef = temp.NextNodeRef; // changes the last node's referecne to be this node
            End = prev; //changes the end of the list to be the previous node checked
            Count--; //decreases the count



        }


        public void Print()
        {
            Console.WriteLine("Singly Linked list");
            SListNode<T> temp = Head;
            for (int i = 1; i <= Count; i++)
            {
                Console.Write("My name is " + temp.data);
                if (i == Count)
                {
                    Console.WriteLine(" and I am at the end of the list ");
                    Console.WriteLine("There are " + Count + " muppets in this list.");
                    Console.WriteLine("Head:" + Head.data + " End:" + End.data);
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine(", I am followed by " + temp.NextNodeRef.data + ".");
                    temp = temp.NextNodeRef;
                }
            }



        }

    }
    public class SListNode<T>  // creates a generic node
    {
        public T data;  // inside each node, the object will have it's data
        public SListNode<T> NextNodeRef;  //and it will carry a reference to the next item in the list
        public int index; //this will be the reference, linked to the count

    }
}








