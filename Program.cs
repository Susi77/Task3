using SortingClassLibrary;
using System;
using System.Diagnostics;
using System.Drawing;

namespace Sorting
{
    class Program
    {
        enum color
        { 
          green
        }

        
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter the Size of Array");
                int ArraySize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Select The Algorithm you want to Perform");
                Console.WriteLine("1.Quick Sort \t2.Bubble Sort  \t3.Merge Sort \t4.Insertion Sort \t5.Count Sort");
                int specificNumberOfAlgorithm = Convert.ToInt32(Console.ReadLine());
                switch (specificNumberOfAlgorithm)
                {
                    case 1:
                        PerformQuickSort(ArraySize);
                        break;
                    case 2:
                        PerformBubbleSort(ArraySize);
                        break;
                    case 3:
                        PerformMergeSort(ArraySize);
                        break;
                    case 4:
                        PerformInsertionSort(ArraySize);
                        break;
                    case 5:
                        PerformCountSort(ArraySize);
                        break;

                }
            }

        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]); Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void PerformQuickSort(int sizeArray)
        {
            SortingAlgorithms sorting = new QuickSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static void PerformBubbleSort(int sizeArray)
        {
            SortingAlgorithms sorting = new BubbleSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static void PerformMergeSort(int sizeArray)
        {
            SortingAlgorithms sorting = new MergeSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }


        static void PerformCountSort(int sizeArray)
        {
            SortingAlgorithms sorting = new CountSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }


        static void PerformInsertionSort(int sizeArray)
        {
            SortingAlgorithms sorting = new InsertionSort(sizeArray);
            sorting.FillArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            sorting.SortArray();
            watch.Stop();
            var arr = sorting.GetSortedArray;
            Print(arr);
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
