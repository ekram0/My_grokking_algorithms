using System;
using System.Collections.Generic;
using System.Linq;

namespace My_Implement.QuickSort
{
    public class QuickSort
    {
        public static int SumByRecursion(IEnumerable<int> list)
            => !list.Any() ? 0 : list.Take(1).FirstOrDefault() + SumByRecursion(list.Skip(1));
        public static int MaxValueByRecursion(IEnumerable<int> list)
        {
            if (!list.Any()) throw new ArgumentException(nameof(list));
            if (list.Count() == 1) return list.First();
            if (list.Count() == 2) return list.FirstOrDefault() > list.Skip(1).FirstOrDefault()
                      ? list.FirstOrDefault() : list.Skip(1).FirstOrDefault();
            var max = MaxValueByRecursion(list.Skip(1));
            return list.FirstOrDefault() > max ? list.FirstOrDefault() : max;

        }

        public static int CountByRecursion(IEnumerable<int> list)
            => !list.Any() ? 0 : 1+ CountByRecursion(list.Skip(1));

        //Get great Comman Divisor
        public static int GetGCD(int FirstNumber, int SecondNumber)
         => SecondNumber == default ? FirstNumber : GetGCD(SecondNumber, FirstNumber % SecondNumber);

        //Get great Comman Divisor of list
        public static int GetGCDList(List<int> lst)
        {
            var result = lst[0];
            result = GetGCD(result, lst.Skip(1).FirstOrDefault());
            return result;
        }

        public static IEnumerable<int> quickSort(IEnumerable<int> arr)
        {
            if (arr is null) return null;
            if (arr.Count() < 2) return arr;
            var pivot = arr.ElementAt((int)(arr.Count() * 0.5));
            var less = arr.Skip(1).Where(i => i <= pivot);
            var greater = arr.Skip(1).Where(i => i > pivot);
            return quickSort(less).Union(new int []{ pivot}).Union(quickSort(greater));
        }

        public static IEnumerable<int> MultiplyTable(IEnumerable<int> lst)
        {
            var result = new List<int>();
            if (!lst.Any()) return null ;
            var val = lst.Take(1).FirstOrDefault() * MultiplyTable(lst.Skip(1)).FirstOrDefault();
            result.Add(val);
            return result;
        }

        //static void Main(string[] args)
        //{
        //    var lst = new List<int> { 130,0,20,-32,258,50,5029,140 };
        //    var lst2 = new List<int> { 1,2,3,4};
        //    var result = SumByRecursion(lst);
        //    var max = MaxValueByRecursion(lst);
        //    var count = CountByRecursion(lst);
        //    var GCD = GetGCD( 640, 1680);
        //    var GCDList = GetGCDList(lst);
        //    var SortedList = quickSort(lst).ToList();
        //    var table = MultiplyTable(lst2);

        //    Console.WriteLine(result);
        //    Console.WriteLine(max);
        //    Console.WriteLine(count );
        //    Console.WriteLine(GCD);
        //    Console.WriteLine(GCDList);
        //    Console.WriteLine(String.Join(" ",quickSort(lst)));
        //    Console.ReadKey();
        //}
    }
}
