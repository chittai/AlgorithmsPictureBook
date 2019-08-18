using System;

namespace _2.Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bubble Sort
            Console.WriteLine("--- bubble sort ---");
            Console.WriteLine(string.Join(",", Initialize()));
            BubbleSort.Sort(Initialize());

            // Selection Sort
            Console.WriteLine("--- selection sort ---");
            Console.WriteLine(string.Join(",", Initialize()));
            SelectionSort.Sort(Initialize());

            // Insertion Sort
            Console.WriteLine("--- insertion sort ---");
            Console.WriteLine(string.Join(",", Initialize()));
            InsertionSort.Sort(Initialize());

            // Merge Sort
            Console.WriteLine("--- merge sort ---");
            Console.WriteLine(string.Join(",", Initialize()));
            MergeSort.Sort(Initialize());

            // Quick Sort
            Console.WriteLine("--- quick sort ---");
            Console.WriteLine(string.Join(",", Initialize()));
            QuickSort.Sort(Initialize());

            // Heap Sort
            Console.WriteLine("--- heap sort ---");
            Console.WriteLine(string.Join(",", Initialize()));
            HeapSort.Sort(Initialize());
        }

        static int[] Initialize()
        {
            int[] array = new int[9] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };
            return array;
        }

    }
}
