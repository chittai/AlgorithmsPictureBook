using System;

namespace _2.Sort
{
    class MergeSort
    {
        public static void Sort(int[] array)
        {
            int left = 0;
            int right = array.Length;
            int[] sortedArray = new int[array.Length];

            int[] result = mergesort(array, sortedArray, left, right);

            Console.WriteLine(string.Join(",", result));

        }

        static int[] mergesort(int[] baseArray, int[] sortedArray, int left, int right)
        {
            int mid = (left + right) / 2;

            if (left == right || left == right - 1) { return null; }

            mergesort(baseArray, sortedArray, left, mid);
            mergesort(baseArray, sortedArray, mid, right);

            merge(baseArray, sortedArray, left, mid, right);

            return baseArray;
        }

        static int[] merge(int[] baseArray, int[] sortedArray, int left, int mid, int right)
        {
            int i = left;
            int j = mid;
            int k = 0;

            while (i < mid && j < right)
            {
                if (baseArray[i] < baseArray[j])
                {
                    sortedArray[k++] = baseArray[i++];
                }
                else
                {
                    sortedArray[k++] = baseArray[j++];
                }
            }

            if (i == mid)
            {
                while (j < right)
                {
                    sortedArray[k++] = baseArray[j++];
                }
            }
            else
            {
                while (i < mid)
                {
                    sortedArray[k++] = baseArray[i++];
                }
            }

            for (int l = 0; l < k; l++)
            {
                baseArray[left + l] = sortedArray[l];
            }

            return baseArray;
        }
    }
}