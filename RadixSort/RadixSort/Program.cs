using System;
using System.Collections.Generic;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 170, 45, 75, 90, 2, 802, 66 };
            PrintArray(values);
            Console.ReadLine();

            PrintRadixSortedArray(RadixSort(values));

            Console.ReadLine();

            int[] valuesTwo = new int[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7 };
            PrintArray(valuesTwo);
            Console.ReadLine();

            PrintRadixSortedArray(RadixSort(valuesTwo));

            Console.ReadLine();
        }
        static int[] RadixSort(int[] unsortedData) { 
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

                } while (Buckets[0].Count != unsortedData.Length) ;
            return unsortedData;
        }
        static int GetPlaces(int value, int places)
        {
            return ((value % (places * 10)) - (value % places)) / places;
        }

        public static void PrintArray(int[] source)
        {
            foreach (int i in source)
            {
                Console.Write(i + ", ");
            }
        }

        public static void PrintRadixSortedArray(int[] source)
        {
            foreach (int i in source)
            {
                Console.Write(i.ToString() + ", ");
            }
        }
    }
}

