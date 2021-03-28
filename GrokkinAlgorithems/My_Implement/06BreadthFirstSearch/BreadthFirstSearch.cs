using System;
using System.Collections.Generic;
using System.Linq;

namespace My_Implement.BreadthFirstSearch
{
    public class BreadthFirstSearch
    {
        private static bool PersonSeller(string name) => name.EndsWith("m");
        
        //BFS(Breadth First Path) => if there is path, the shortest path
        private static bool Search(string name, Dictionary<string, string[]> graph)
        {
            if (string.IsNullOrWhiteSpace(name) || graph is null) return false;

            var SearchQueue = new Queue<string>(graph[name]);
            var Searched = new List<string>();

          
            while (SearchQueue.Any())
            {
                var Person = SearchQueue.Dequeue();
                if (!Searched.Contains(Person))
                {
                    if (PersonSeller(Person))
                    {
                        Console.WriteLine($"{Person} is a mango seller");
                        return true;
                    }
                    else
                    {
                        SearchQueue = new Queue<string>(SearchQueue.Concat(graph[Person]));
                        Searched.Add(Person);
                    }
                }
            }
            return false;
        }

       

        //static void Main(string[] args)
        //{

        //    var graph = new Dictionary<string, string[]>();
        //    graph.Add("you", new[] { "alice", "bob", "claire" });
        //    graph.Add("bob", new[] { "anuj", "peggy" });
        //    graph.Add("alice", new[] { "peggy" });
        //    graph.Add("claire", new[] { "thom", "jonny" ,"Mollm"});
        //    graph.Add("anuj", Array.Empty<string>());
        //    graph.Add("peggy", Array.Empty<string>());
        //    graph.Add("thom", Array.Empty<string>());
        //    graph.Add("jonny", Array.Empty<string>());
        //    Search("you", graph);
        //    Console.ReadKey();
        //}
    }
}


