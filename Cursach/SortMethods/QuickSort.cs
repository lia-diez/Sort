using System;

namespace SortMethods
{
    public static class QuickSort
    {
        /// <summary>
        /// Сортування масиву за допомогою алгоритму quick sort
        /// </summary>
        public static void Sort<T>(T[] array, int lowIndex, int highIndex)
            where T : IComparable<T>
        {
            if (lowIndex >= highIndex) return;
            int elem = Divide(array, lowIndex, highIndex);
            Sort(array, lowIndex, elem - 1);
            Sort(array, elem+1, highIndex);
        }
        
        private static int Divide<T>(T[] array, int low, int high)
            where T : IComparable<T>
        {
            int a = low;
            for (int i = a; i <= high; i++)
            {
                if (array[i].CompareTo(array[high]) <= 0)  ////////////////
                {
                    Swap(ref array[a], ref array[i]);
                    a++;
                }
            }

            return a - 1;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}