using System;
using System.Collections.Generic;

namespace RadixSort250221
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = GetPlaces(12, 1);
            int j = GetPlaces()
            int[] unsortedData = new[] { 170, 45, 75, 90, 2, 802, 66 };

            Console.WriteLine(RadixSort(unsortedData));








            Console.ReadLine();
        }

        static int GetPlaces(int value, int places)
        {
            return ((value % (places * 10)) - (value % places)) / places;
        }

        static int[] RadixSort(int[] unsortedData)
        {
            List<int>[] Buckets = new List<int>[10];

            for (int i = 0; i < Buckets.Length; i++)
            {
                Buckets[i] = new List<int>();
            }

            int Column = 10;

            for (int Columns = 10; Columns < Column; Columns*=10)
            {
                foreach (int Element in unsortedData)
                {
                    int BucketIndex = GetPlaces(Element % Column);
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
            }
        }

    }
}
