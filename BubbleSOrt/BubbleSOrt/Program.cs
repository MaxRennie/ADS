using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new[] { 4, 16, 29, 28, 12, 8, 10, 20, 1, 19, 8, 16 };
            foreach (int i in values)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            //create sorted array
            //iterate through elements
            //--Select value at index i
            //--Compare to index i +1
            //--If value in i is < i + 1, swap the values
            //--Increment i
            //--Repeat until i = array size - 1
            foreach (int item in values)
            {
                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        SwapValues(values, i, i + 1);
                    }
                }
            }
            foreach (int i in values)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void SwapValues(int[] source, int index1, int index2)
        {
            int temp;
            temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }
        //reference -- https://stackoverflow.com/questions/43759043/how-can-i-swap-two-values-of-an-array-in-c
    }
}
