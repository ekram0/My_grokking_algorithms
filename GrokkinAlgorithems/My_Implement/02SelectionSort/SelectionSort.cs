using System;
using System.Collections.Generic;

namespace My_Implement.SelectionSort
{
    public class SelectionSort
    {
        private static int FindSmallest(List<int> list)
        {
            if (list is null)
                throw new ArgumentException($"{nameof(list)} is null");

            var SmallestValue = list[0];
            var SmallestIndex = 0;
            for (int i = 0; i < list?.Count; i++)
            {
                if (list[i] < SmallestValue)
                {
                    SmallestValue = list[i];
                    SmallestIndex = i;
                }
            }
            return SmallestIndex;
        }

        public static int[] selectionSort(List<int> list)
        {
            if (list is null) return null;

            var result = new int[list.Count];
            for (int i = 0; i < result.Length; i++)
            {
                var smallest = FindSmallest(list);
                result[i] = list[smallest];
                list.RemoveAt(smallest);
            }

            return result;
        }

        public static List<T> GenericSelectionSort<T>(List<T> list) where T : IComparable<T>
        {
            if (list is null)
                return null;

            for (int i = 0; i < list?.Count; i++)
            {
                var smallestIndex = i;
                for (int j = i; j < list?.Count; j++)
                    if (list[smallestIndex].CompareTo(list[j]) > 0)
                        smallestIndex = j;
                (list[i], list[smallestIndex]) = (list[smallestIndex], list[i]);
            }

            return list;
        }
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 5, 3, 9, 10, 20, -1 };
            var StringList = new List<string>() { "India", "Egypt", "England", "Germany", "Gana" };
            foreach (var item in GenericSelectionSort(StringList))
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
