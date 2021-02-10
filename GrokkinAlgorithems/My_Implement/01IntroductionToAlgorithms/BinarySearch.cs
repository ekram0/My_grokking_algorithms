using System;
using System.Linq;

namespace My_Implement.IntroductionToAlgorithms
{
    public class BinarySearch
    {
        public static int binarySearch(int[] list, int item)
        {
            var Low = 0;
            var High = list.Length - 1;
            if (!list.Contains(item)) return -1;
            while (Low <= High)
            {
                int mid = (Low + High) / 2;
                var guss = list[mid];
                switch (guss)
                {
                    case var t when guss == item: return mid;
                    case var t when guss > item: High = mid - 1; break;
                    default: Low = mid + 1;break;
                }

            }
            return -1;
        }

        static void Main(string[] args)
        {
            var data = Enumerable.Range(0, 1000).ToArray();
            var item = 804;
            var target = binarySearch(data, item);
            Console.WriteLine(target);
            Console.ReadKey();
        }
    }
}
