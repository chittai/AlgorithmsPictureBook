using System;

namespace _2.Sort
{
    class QuickSort
    {
        public static void Sort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            quicksort(array, left, right);
            Console.WriteLine(string.Join(",", array));

        }

        static void quicksort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right;
                int pivot = Median3Value(array[left], array[left + (right - left) / 2], array[right]);

                while (true)
                {
                    while (array[i] < pivot) { i++; }
                    while (pivot < array[j]) { j--; }
                    if (j <= i) { break; }

                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
                quicksort(array, left, i - 1);
                quicksort(array, j + 1, right);
            }
        }

        /// <summary>
        /// 与えられた3つの値から中央値を返す
        /// </summary>
        static int Median3Value(int a, int b, int c)
        {
            if (a < b)
            {
                if (c < a) { return a; }
                else if (b < c) { return b; }
                else { return c; }
            }
            else
            {
                if (c < b) { return b; }
                else if (a < c) { return a; }
                else { return c; }
            }
        }
    }
}