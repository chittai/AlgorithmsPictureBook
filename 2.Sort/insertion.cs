using System;

namespace _2.Sort
{
    class InsertionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                for (int j = i - 1; 0 <= j; j--)
                {
                    if (array[index] < array[j])
                    {
                        int tmp = array[index];
                        array[index] = array[j];
                        array[j] = tmp;
                        index = j;
                    }
                    else { break; }
                }
            }
            Console.WriteLine(string.Join(",", array));
        }
    }
}