using System;


namespace BinMinHeapArr
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap();
            Console.ReadLine();
        }

        private static void MinHeap()
        {
            int[] values = new int[] { 1, 7, 8, 4, 9, 3, 10};
            int[] BinMinHeapArr = new int[values.Length];
            int count = 0;

            Add(0, BinMinHeapArr);
            Add(1, BinMinHeapArr);
            Add(2, BinMinHeapArr);
            Add(3, BinMinHeapArr);
            Add(4, BinMinHeapArr);
            Add(5, BinMinHeapArr);
            Add(6, BinMinHeapArr);
            PrintArray(BinMinHeapArr);
            Console.WriteLine();
            Remove(BinMinHeapArr);
            PrintArray(BinMinHeapArr);
            Console.ReadLine();

            void Add(int indexOfItemToAdd, int[] targetArr)
            {
                int itemToAdd = values[indexOfItemToAdd];
                targetArr[count] = itemToAdd;

                if (count!= 0 && targetArr[count] < targetArr[FindIndexOfParentNode(count)])
                    SwapValues(targetArr, count, FindIndexOfParentNode(count));

                count++;
            }

            void Remove(int[] targetArr)
            {
                targetArr[0] = default;
                BubbleUp(targetArr);
            }

            void BubbleUp(int[] targetArr)
            {
                for (int i = 0; i < targetArr.Length-1; i++)
                {
                    int LeftChildIndex = FindIndexOfLeftChildOfNode(i, targetArr);
                    int rightChildIndex = FindIndexOfRightChildOfNode(i, targetArr);
                    if(targetArr[i] == default)
                    {
                        //if left child <=right child, and left+ right children are not 0
                        if(targetArr[LeftChildIndex] <= targetArr[rightChildIndex] && rightChildIndex != default && LeftChildIndex != default)
                        {
                            //swap left child and targetArr[i] 
                            SwapValues(targetArr, i, LeftChildIndex);
                        }
                        //else if right child < left child, and left+ right children are not 0
                        else if (targetArr[rightChildIndex] < targetArr[LeftChildIndex] && rightChildIndex != 0 && LeftChildIndex != 0)
                        {
                            //swap right child and targetArr[i] 
                            SwapValues(targetArr, i, rightChildIndex);
                        }
                    }
                    if(targetArr[rightChildIndex] > targetArr[LeftChildIndex])
                    {
                        SwapValues(targetArr, rightChildIndex, LeftChildIndex);
                    }
                }
            }

            void SwapValues(int[] source, int index1, int index2)
            {
                //reference -- https://stackoverflow.com/questions/43759043/how-can-i-swap-two-values-of-an-array-in-c
                int temp;
                temp = source[index1];
                source[index1] = source[index2];
                source[index2] = temp;
            }

            int FindIndexOfParentNode(int IndexOfCurrentNode)
            {
                int IndexOfParentNode = (int)Math.Floor((IndexOfCurrentNode - 1.0) / 2);
                return IndexOfParentNode;
            }

            int FindIndexOfLeftChildOfNode(int IndexOfCurrentNode, int[] targetArr)
            { 
            int IndexOfLeftChild = 2 * IndexOfCurrentNode + 2;
            if (IndexOfLeftChild < targetArr.Length)
            {
                return 2 * IndexOfCurrentNode + 1;
            }
                else
                return default;
            }

            int FindIndexOfRightChildOfNode(int IndexOfCurrentNode, int[] targetArr)
            {
                int IndexOfRightChild = 2 * IndexOfCurrentNode + 2;
                if (IndexOfRightChild < targetArr.Length)
                {
                    return 2 * IndexOfCurrentNode + 2;
                }
                else
                    return default;
            }
            void PrintArray(int[] source)
            {
                
                foreach (int i in source)
                {
                    if (i != default)
                    {
                        Console.WriteLine(i + ", ");
                    }
                    
                }
            }

        }
    }
}
