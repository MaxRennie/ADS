using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinSearchTree();
            Console.ReadLine();
        }

        private static void BinSearchTree()
        {
            int[] values = new int[] { 64, 2, 9, 87, 23, 44, 99, 12 };
            int[] BinSearchTreeArr = new int[values.Length];
            int count = 0;

            Add(0, BinSearchTreeArr);
            Add(1, BinSearchTreeArr);
            Add(2, BinSearchTreeArr);
            Add(3, BinSearchTreeArr);
            Add(4, BinSearchTreeArr);
            Add(5, BinSearchTreeArr);
            Add(6, BinSearchTreeArr);
            Add(7, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine(Search(12, BinSearchTreeArr, 0));
            Console.WriteLine(Search(97, BinSearchTreeArr, 0));
            Console.ReadLine();

            void Add(int indexOfItemToAdd, int[] targetArr)
            {
                int itemToAdd = values[indexOfItemToAdd];

                if (count == 0)
                {
                    targetArr[count] = itemToAdd;
                }
                else 
                {
                    CompareAndPlace(0, itemToAdd, targetArr);
                }
                count++;
            }

            void CompareAndPlace(int indexToCompare, int itemToAdd, int[] targetArr)
            {
                if (itemToAdd < targetArr[indexToCompare]) // if item smaller than root
                {
                    if (FindValueOfLeftChild(indexToCompare, targetArr) == default)//if left child is default
                    {
                        targetArr[FindIndexOfLeftChild(indexToCompare, targetArr)] = itemToAdd; //put itemtoadd as left child
                    }
                    else
                    {
                        CompareAndPlace(FindIndexOfLeftChild(indexToCompare, targetArr), itemToAdd, targetArr);
                    }
                }
                if (itemToAdd > targetArr[indexToCompare])
                {
                    if (FindValueOfRightChild(indexToCompare, targetArr) == default)//if Right child is default
                    {
                        targetArr[FindIndexOfRightChild(indexToCompare, targetArr)] = itemToAdd; //put itemtoadd as Right child
                    }
                    else
                    {
                        CompareAndPlace(FindIndexOfRightChild(indexToCompare, targetArr), itemToAdd, targetArr);
                    }
                }
            }

            bool Search(int searchItem, int[] targetArr, int startPoint)
            {
                bool result = false;
                if (targetArr[startPoint] == default)
                {
                    return result;
                }
                if (targetArr[startPoint] == searchItem)
                {
                    result = true;
                } else if (targetArr[startPoint] < searchItem) {
                    result = Search(searchItem, targetArr, FindIndexOfRightChild(startPoint, targetArr));
                } else if (targetArr[startPoint] > searchItem)
                {
                    result = Search(searchItem, targetArr, FindIndexOfLeftChild(startPoint, targetArr));
                }
                return result;
            }

            int FindIndexOfLeftChild(int IndexOfCurrentNode, int[] targetArr)
            {
                int IndexOfLeftChild = 2 * IndexOfCurrentNode + 1;
                if (IndexOfLeftChild < targetArr.Length-1)
                {
                    return IndexOfLeftChild;
                }
                if (IndexOfLeftChild > targetArr.Length-1)
                {
                    IncreaseArrSize(targetArr);
                    FindIndexOfLeftChild(IndexOfCurrentNode, targetArr);
                }
                return default;
            }

            int FindValueOfLeftChild(int IndexOfCurrentNode, int[] targetArr)
            {
                int IndexOfLeftChild = 2 * IndexOfCurrentNode + 1;
                if (IndexOfLeftChild < targetArr.Length - 1)
                {
                    return targetArr[IndexOfLeftChild];
                }
                if (IndexOfLeftChild > targetArr.Length - 1)
                {
                    IncreaseArrSize(targetArr);
                    FindIndexOfLeftChild(IndexOfCurrentNode, targetArr);
                }
                return default;
            }

            int FindIndexOfRightChild(int IndexOfCurrentNode, int[] targetArr)
            {
                int IndexOfRightChild = 2 * IndexOfCurrentNode + 2;
                if (IndexOfRightChild < targetArr.Length - 1)
                {
                    return IndexOfRightChild;
                }
                if (IndexOfRightChild > targetArr.Length - 1)
                {
                    IncreaseArrSize(targetArr);
                    FindIndexOfRightChild(IndexOfCurrentNode, targetArr);
                }
                return default;
            }

            int FindValueOfRightChild(int IndexOfCurrentNode, int[] targetArr)
            {
                int IndexOfRightChild = 2 * IndexOfCurrentNode + 2;
                if (IndexOfRightChild < targetArr.Length - 1)
                {
                    return targetArr[IndexOfRightChild];
                }
                if (IndexOfRightChild > targetArr.Length - 1)
                {
                    IncreaseArrSize(targetArr);
                    FindIndexOfRightChild(IndexOfCurrentNode, targetArr);
                }
                return default;
            }

            int[] IncreaseArrSize(int[] arr)
            {

                int[] arr2 = new int[arr.Length + 10];
                Array.Copy(arr, arr2, arr.Length);
                return arr2;
            }

            void PrintArray(int[] source)
            {
                foreach (int i in source)
                {
                    if (i != default)
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
        }
    }
}

