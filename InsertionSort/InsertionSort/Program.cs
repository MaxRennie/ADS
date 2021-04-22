using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7 };

            PrintArray(values);
            Console.WriteLine();

            PrintArray(insertionSort(values));
            Console.ReadLine();

            //For i elements in array
            //J = i
            //While j > 0 and(array[j - 1] > array[j])
            //Swap array[j] and array[j - 1]
            //J--
            //i++

            //take element
            //compare to every element behind it
            //when current is bigger than compared element - place.
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
        public static void SwapValues(int[] source, int index1, int index2)
        {
        //reference -- https://stackoverflow.com/questions/43759043/how-can-i-swap-two-values-of-an-array-in-c
            int temp;
            temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }

        public static void PrintArray(int[] source)
        {
            foreach (int i in source)
            {
                Console.Write(i + ", ");
            }
        }

    }
}
