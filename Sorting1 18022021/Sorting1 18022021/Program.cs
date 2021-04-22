using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1_18022021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7 };

            //Selection sort
            //Create secondary array, known as Sorted Array, set to lenth of values
            //foreach Element I
            //---Iterate over all elements -> J
            //------Keep track of smallest overwrite if current element is smaller
            //---Insert smallest value  into sorted array at index I

            //Selection Sort
            //Create secondary array, known as Sorted Array, set to lenth of values
            int[] Sorted = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int smallest = values[0];
                int smallestIindex = 0;
                for (int j = 0; j < values.Length; j++) //
                {                                    //
                    if (values[j] < smallest)
                    {
                        smallest = values[j];
                        smallestIindex = j;
                    }
                }
                values[smallestIindex] = int.MaxValue;
                Sorted[i] = smallest;
            }

            Console.WriteLine("Naff Selection");
            foreach (int i in Sorted)
            {
                Console.Write(i + ", ");
            }
         
            int[] values2 = new[] { 4, 9, 7, 45, 6, 2, 14, 68, 5, 7 };
            for (int i = 0; i < values.Length - 1; i++)
            {
                int smallest = int.MaxValue;
                int smallestLocation = i;
                for (int j=i; j <= values2.Length - 1; j++)
                {
                    if (values2[j] < smallest)
                    {
                        smallest = values2[j];
                        smallestLocation = j;
                    }
                }
                int temp = values2[i];
                values2[i] = smallest;
                values2[smallestLocation] = temp;
            }

            Console.WriteLine("\nGood Selection");
            foreach (int i in values2)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }



    }
}
