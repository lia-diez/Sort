using System;
using System.Diagnostics;
using SortMethods;

namespace Cursach
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            //int[] array = new int[100];
            var array = new[]{"rt", "werw", "ghffgh", "sasda", "abc", "11", "sasdb", "sasd", "sasd"};
            //array = array.Select(a => random.Next(-100, 100)).ToArray();
            //Console.WriteLine(string.Join(" ", array));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MergeSort.Sort(array, 0, array.Length-1);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}