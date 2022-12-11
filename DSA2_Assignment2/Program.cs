
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using DSA2_Assignment2;

namespace DSA2_Assignment2
{
    public class Program
    {
        public static List<Link> links = new List<Link>();

        public static void Init()
        {
            links.Add(new Link("Dobrich", "Razgrad", 153,  80));
            links.Add(new Link("Dobrich", "Silistra", 90,  80));
            links.Add(new Link("Varna", "Burgas", 115, 80));
            links.Add(new Link("Varna", "Dobrich", 53,  80));
            links.Add(new Link("Varna", "Shumen", 89, 80));
            links.Add(new Link("Burgas", "Yambol", 92, 80));
            links.Add(new Link("Burgas", "Shumen", 127, 80));
            links.Add(new Link("Yambol", "Stara Zagora", 87, 80));
            links.Add(new Link("Yambol", "Silven", 29, 80));
            links.Add(new Link("Silven", "Tyrgowishte", 112, 80));
            links.Add(new Link("Silven", "Kazanlyk", 86, 80));
            links.Add(new Link("Silven", "Stara Zagora", 69, 80));
            links.Add(new Link("Silven", "Veliko Trynovo", 112, 80));
            links.Add(new Link("Tyrgowishte", "Shumen", 41, 80));
            links.Add(new Link("Shumen", "Razgrad", 48, 80));
            links.Add(new Link("Silistra", "Razgrad", 108, 80));
            links.Add(new Link("Razgrad", "Veliko Trynovo", 117, 80));
            links.Add(new Link("Stara Zagora", "Kazanlyk", 36, 80));
            links.Add(new Link("Shumen", "Veliko Trynovo", 140, 80));
            links.Add(new Link("Tyrgowishte", "Veliko Trynovo", 100, 80));
            links.Add(new Link("Kazanlyk", "Veliko Trynovo",100, 80));

        }

        public static List<string> GetNeighbours(string node)
        {
            List<string> result = new List<string>();
            foreach(Link link in links)
            {
                if(link.vertex_1 == node)
                {
                    result.Add(link.vertex_2);
                }
                if(link.vertex_2 == node)
                {
                    result.Add(link.vertex_1);
                }
            }
            return result;
        }

        public static void PrintAllNeighbours(string allNeighbours)
        {   
            foreach (var neighbours in GetNeighbours(allNeighbours))
            {
                Console.WriteLine(neighbours);
            }
        }


        internal static List<String> FindPath(String start, String end, List<String> visited)
        {
            if (visited.Contains(start))
                return null;

            visited.Add(start);
            List<string> neighbors = GetNeighbours(start);

            // check if any neighbor is the end, if yes, we found a path
            foreach (String neighbor in neighbors)
            {
                if (neighbor == end)
                {
                    List<string> result = new List<String>();
                    result.Add(end);
                    result.Add(start);
                    return result;
                }
            }

            // apply recursively to all neighbors
            foreach (String neighbor in neighbors)
            {
                List<String> path = FindPath(neighbor, end, visited);
                if (path != null)
                {
                    path.Add(start);
                    return path;
                }
            }

            // no path is found through the start node
            return null;
        }

        //public static List<string> FindPath(string start, string end, List<string> visited)
        //{
        //    if (visited.Contains(start))
        //    {
        //        return null;
        //    }
        //    visited.Add(start);

        //    List<string> neighbours = GetNeighbours(start);

        //    foreach (string neighbour in neighbours)
        //    {
        //        if (neighbour == end)
        //        {
        //            List<string> result = new List<string>();
        //            result.Add(end);
        //            result.Add(start);
        //            return result;
        //        }
        //    }
        //    foreach (string neighbour in neighbours)
        //    {
        //        List<string> path = FindPath(start, end, visited);
        //        if (path != null)
        //        {
        //            path.Add(start);
        //            return path;
        //        }
        //    }
        //    return null;
        //}

        //internal static List<string> BFS(string start, string end, List<string> visited)
        //{
        //    if (visited.Contains(start)) return null;
        //    visited.Add(start);

        //    Queue<string> queue = new Queue<string>();

        //    queue.Enqueue(start);

        //    List<string> neighbours = GetNeighbours(start);

        //    while (queue.Count != 0)
        //    {
        //        string v = queue.Dequeue();

        //        if (v == end) break;
        //        else
        //        {
        //            foreach (var neighbour in neighbours)
        //            {
        //                List<String> path = FindPath(neighbour, end, visited);
        //                if (path != null)
        //                {
        //                    path.Add(start);
        //                   // Console.WriteLine(start);
        //                    return path;
        //                }
        //            }
        //        }
        //    }

        //    return null;
        //}


        internal static List<string> DFS(string start, string end, List<string> visited)
        {
            if (visited.Contains(start)) return null;
            visited.Add(start);

            Stack<string> stack = new Stack<string>();

            stack.Push(start);

            List<string> neighbours = GetNeighbours(start);

            while (stack.Count != 0)
            {
                string v = stack.Pop();

                if (v == end) break;
                else
                {
                    foreach (var neighbour in neighbours)
                    {
                        List<String> path = FindPath(neighbour, end, visited);
                        if (path != null)
                        {
                            path.Add(start);
                            // Console.WriteLine(start);
                            return path;
                        }
                    }
                }
            }

            return null;
        }

        internal static void FindShortestPath(string start, string end)
        {

        }


    }
}





