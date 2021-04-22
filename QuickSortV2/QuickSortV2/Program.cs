using System;

namespace QuickSortV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7, 6 };
            PrintArray(values);
            Console.WriteLine();
            Quicksort(values);
            PrintArray(values);
            Console.ReadLine();
        }   

        static void Quicksort(int[] source) { 
        int pivot = source[0];
        int highIndex = source.Length - 1;
        int lowIndex = 1;

        int high = source[highIndex];
        int low = source[lowIndex];

            for (int i = 0; i < source.Length; i++)
            {
                if (low < pivot && high > pivot)
                {
                    SwapValues(source, lowIndex, highIndex);
                    highIndex--;
                    lowIndex++;
                }

            }
        }
        public static void SwapValues(int[] source, int index1, int index2)
        {
            int temp;
            temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }
        //reference -- https://stackoverflow.com/questions/43759043/how-can-i-swap-two-values-of-an-array-in-c
        public static void PrintArray(int[] source)
        {
            foreach (int i in source)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
