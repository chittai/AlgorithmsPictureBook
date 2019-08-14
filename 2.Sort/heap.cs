using System;

namespace _2.Sort
{
    class HeapSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                MakeHeap(array, i);
            }
            Console.WriteLine(string.Join(",", array));

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = PopHeap(array, i);
            }
            Console.WriteLine(string.Join(",", array));
        }

        static void MakeHeap(int[] array, int n)
        {
            while (n != 0)
            {
                int i = (n - 1) / 2;
                if (array[n].CompareTo(array[i]) > 0) Swap(ref array[n], ref array[i]);
                n = i;
            }
        }

        static int PopHeap(int[] array, int n)
        {
            int max = array[0];
            array[0] = array[n];

            for (int i = 0, j; (j = 2 * i + 1) < n;)
            {
                if ((j != n - 1) && (array[j].CompareTo(array[j + 1]) < 0)) j++;
                if (array[i].CompareTo(array[j]) < 0) Swap(ref array[i], ref array[j]);
                i = j;
            }
            return max;
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T tmp = lhs;
            lhs = rhs;
            rhs = tmp;
        }
    }
}