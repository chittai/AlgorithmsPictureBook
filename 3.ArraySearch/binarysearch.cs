using System;

namespace _3.ArraySearch
{
    class BinarySearch
    {
        public static void Search(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            binarysearch(array, 0, left, right);
            binarysearch(array, 1, left, right);
            binarysearch(array, 2, left, right);
            binarysearch(array, 3, left, right);
            binarysearch(array, 4, left, right);
            binarysearch(array, 5, left, right);
            binarysearch(array, 6, left, right);
            binarysearch(array, 7, left, right);
            binarysearch(array, 8, left, right);
            binarysearch(array, 9, left, right);
            binarysearch(array, 10, left, right);

        }

        static void binarysearch(int[] array, int value, int left, int right)
        {
            int mid = left + (right - left) / 2;
            if (left <= right)
            {
                if (array[mid] < value)
                {
                    mid++;
                    binarysearch(array, value, mid, right);
                }
                else if (value < array[mid])
                {
                    mid--;
                    binarysearch(array, value, left, mid);
                }
                else if (array[mid] == value)
                {
                    Console.WriteLine(value + " is exsisted.And index is " + mid + ".");
                }
            }
        }
    }
}