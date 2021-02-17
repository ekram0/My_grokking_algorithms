using System;

namespace My_Implement.Recursion
{
    public class Recursion
    {
        public static void CountDown(int number)
        {
            Console.WriteLine(number);
            if (number > 0)
                CountDown(number - 1);
        }


        //static void Main(string[] args)
        //{
        //    CountDown(5);
        //    Console.ReadKey();
        //}
    }
}
