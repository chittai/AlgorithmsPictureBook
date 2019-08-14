using System;

namespace _2.Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input
            int[] array = new int[9] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

            // Bubble Sort
            Console.WriteLine("--- bubble sort ---");
            BubbleSort.Sort(array);

            // Selection Sort
            Console.WriteLine("--- selection sort ---");
            SelectionSort.Sort(array);

            // Insertion Sort
            Console.WriteLine("--- insertion sort ---");
            SelectionSort.Sort(array);

        }
    }
}
