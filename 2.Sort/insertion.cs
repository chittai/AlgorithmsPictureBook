using System;

namespace _2.Sort
{
    class InsertionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j <= 0; j--)
                {
                    if (array[i] < array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                    else { break; }
                }
            }
            Console.WriteLine(string.Join(",", array));
        }
    }
}