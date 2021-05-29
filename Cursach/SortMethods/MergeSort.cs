using System;

namespace SortMethods
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] array, int lowIndex, int highIndex)
            where T : IComparable<T>
        {
            if (lowIndex < highIndex)
            {
                int middle = (lowIndex + highIndex) / 2;
                Sort(array, lowIndex, middle);
                Sort(array, middle + 1, highIndex);
            
                Merge(array, lowIndex, middle, highIndex);
            }
        }

        private static void Merge<T>(T[] array, int left, int middle, int right)
            where T : IComparable<T>
        {
            T[] leftArray = Copy(array, new T[middle - left + 1], left);
            T[] rightArray = Copy(array, new T[right - middle], middle + 1);

            int resIndex = left;
            int i = 0;
            int j = 0;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i].CompareTo(rightArray[j]) > 0)       /////////
                {
                    array[resIndex] = leftArray[i];
                    resIndex++;
                    i++;
                }
                else
                {
                    array[resIndex] = rightArray[j];
                    resIndex++;
                    j++;
                }
            }

            while (i < leftArray.Length)
            {
                array[resIndex] = leftArray[i];
                resIndex++;
                i++;
            }

            while (j < rightArray.Length)
            {
                array[resIndex] = rightArray[j];
                resIndex++;
                j++;
            }
        }

        private static T[] Copy<T>(T[] sourceArray, T[] destinationArray, int lowIndex)
        {
            for (int i = 0; i < destinationArray.Length; i++)
            {
                destinationArray[i] = sourceArray[lowIndex + i];
            }

            return destinationArray;
        }
    }
}