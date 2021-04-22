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
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(1, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(2, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(3, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(4, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(5, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(6, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            Add(7, BinSearchTreeArr);
            PrintArray(BinSearchTreeArr);
            Console.WriteLine();
            //Console.WriteLine(Search(12, BinSearchTreeArr, 0));
            //Console.WriteLine(Search(97, BinSearchTreeArr, 0));
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
                int FindIndexOfLeftChild(int IndexOfCurrentNode, int[] targetArrAdd)
                {
                    int IndexOfLeftChild = 2 * IndexOfCurrentNode + 1;
                    if (IndexOfLeftChild < targetArrAdd.Length - 1)
                    {
                        return IndexOfLeftChild;
                    }
                    if (IndexOfLeftChild > targetArrAdd.Length - 1)
                    {
                        targetArrAdd = IncreaseArrSize(targetArrAdd);
                        FindIndexOfLeftChild(IndexOfCurrentNode, targetArrAdd);
                    }
                    return default;
                }

                int FindValueOfLeftChild(int IndexOfCurrentNode, int[] targetArrAdd)
                {
                    int IndexOfLeftChild = 2 * IndexOfCurrentNode + 1;
                    if (IndexOfLeftChild < targetArrAdd.Length - 1)
                    {
                        return targetArrAdd[IndexOfLeftChild];
                    }
                    if (IndexOfLeftChild > targetArrAdd.Length - 1)
                    {
                        targetArrAdd = IncreaseArrSize(targetArrAdd);
                        FindValueOfLeftChild(IndexOfCurrentNode, targetArrAdd);
                    }
                    return default;
                }

                int FindIndexOfRightChild(int IndexOfCurrentNode, int[] targetArrAdd)
                {
                    int IndexOfRightChild = 2 * IndexOfCurrentNode + 2;
                    if (IndexOfRightChild < targetArrAdd.Length - 1)
                    {
                        return IndexOfRightChild;
                    }
                    if (IndexOfRightChild > targetArrAdd.Length - 1)
                    {
                        targetArrAdd = IncreaseArrSize(targetArrAdd);
                        FindIndexOfRightChild(IndexOfCurrentNode, targetArrAdd);
                    }
                    return default;
                }

                int FindValueOfRightChild(int IndexOfCurrentNode, int[] targetArrAdd)
                {
                    int IndexOfRightChild = 2 * IndexOfCurrentNode + 2;
                    if (IndexOfRightChild < targetArrAdd.Length - 1)
                    {
                        return targetArrAdd[IndexOfRightChild];
                    }
                    if (IndexOfRightChild > targetArr.Length - 1)
                    {
                        targetArrAdd = IncreaseArrSize(targetArrAdd);
                        FindValueOfRightChild(IndexOfCurrentNode, targetArrAdd);
                    }
                    return default;
                }

                int[] IncreaseArrSize(int[] arr)
                {
                    int[] arr2 = new int[arr.Length + 10];
                    Array.Copy(arr, arr2, arr.Length);
                    return arr2;
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

                int FindIndexOfLeftChild(int IndexOfCurrentNode, int[] targetArrSearch)
                {
                    int IndexOfLeftChild = 2 * IndexOfCurrentNode + 1;
                    if (IndexOfLeftChild < targetArr.Length - 1)
                    {
                        return IndexOfLeftChild;
                    }
                    else
                    return default;
                }

                int FindIndexOfRightChild(int IndexOfCurrentNode, int[] targetArrSearch)
                {
                    int IndexOfRightChild = 2 * IndexOfCurrentNode + 2;
                    if (IndexOfRightChild < targetArr.Length - 1)
                    {
                        return IndexOfRightChild;
                    }
                    else
                        return default;
                }
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

