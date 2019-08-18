using System;

namespace _2.Sort
{
    class SelectionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int index = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] <= min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                array[index] = array[i];
                array[i] = min;
            }

            Console.WriteLine(string.Join(",", array));
        }
    }
}