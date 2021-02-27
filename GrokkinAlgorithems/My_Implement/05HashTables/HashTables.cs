using System;
using System.Collections.Generic;

namespace My_Implement.HashTables
{
    public class HashTables
    {
        private static Dictionary<string, bool> voted = new Dictionary<string, bool>();
        public static void CheckVoter(string name)
        {
            if (voted.ContainsKey(name))
                Console.WriteLine("you voted!!");

            voted.TryAdd(name, true);
            Console.WriteLine("let them vote");

        }

        #region cashing
        private static Dictionary<string, string> cashe = new Dictionary<string, string>();
        private static string SamulateWorkFromServer(string url) => "data";
        public static string GetPage(string url)
        {

            if (cashe.TryGetValue(url, out string data))
                return data;

            data = SamulateWorkFromServer(url);
            if (!cashe.TryAdd(url, data))
                return null;
            return data;
        }
        #endregion

        //static void Main(string[] args)
        //{
        //    CheckVoter("tom");
        //    CheckVoter("tom");
        //    CheckVoter("abbas");


        //    Console.ReadKey();
        //}
    }
}
