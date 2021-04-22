using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch();
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

            Console.WriteLine(search(Data, 643));
            Console.ReadLine();
        }
        static bool search(List<int> data, int searchItem) { 
            bool result = false;
            data.Sort();
            int mid = data.Count / 2;
            if(mid == default)
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
    }
}
