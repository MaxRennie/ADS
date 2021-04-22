using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7, 6 };
            PrintArray(values);
            Console.ReadLine();
            SortArray(values);
            PrintArray(values);
            Console.ReadLine();
        }

        private static void SortArray(int[] values)
        {
            QuickSort(values, 0, values.Length - 1);
        }
        private static void QuickSort(int[] values, int LoIndex, int HiIndex)
        {
            int i = LoIndex;
            int j = HiIndex;
            int pivot = values[(LoIndex + HiIndex) / 2];

            while(i<= j)
            {
                while (values[i] < pivot)
                    i++;
                while (values[j] > pivot)
                    j--;

                if (i<=j)
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
