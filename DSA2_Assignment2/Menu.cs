using System;

namespace DSA2_Assignment2
{
	public class Menu
	{
		public static void Main(string[] args)
		{
            //Console.WriteLine("\t\tWelcome to Eastern-BG transit");
            //Console.WriteLine();
            //Console.WriteLine("Here are our current locations, PLease choose an origin and destination point:");
            //Console.WriteLine();
            //Console.WriteLine("1. Varna \t2. Burgas \t3. Dobrich \t4. Silistra\n" +
            //				  "5. Razgrad \t6. Tyrgowishte \t7. Shumen \t8. Veliko Trynovo\n" +
            //				  "9. Sliven \t10. Yambol \t11. Kazanlyk \t12. Stara Zagora");
            //Console.WriteLine();
            //Console.WriteLine("Choose City of Origin (1-12): ");
            //int originInput=int.Parse(Console.ReadLine());

            //         Console.WriteLine("Choose City of Final Destination (1-12): ");
            //         int destinationInput = int.Parse(Console.ReadLine());

            //foreach (var item in )
            //{

            //}

            //var pathFoundBFS = Graph.BFS("Varna", "Burgas", new List<string>());

            
            Program.Init();
            //var pathFoundBFS = Graph.BFS("Burgas", "Varna", new List<string>());
            //for (int i = 0; i < pathFoundBFS.Count; i++)
            //{
            //    Console.WriteLine(pathFoundBFS[i]);
            //}

            //for (int i = pathFoundBFS.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(pathFoundBFS[i]);
            //}


            //var neigh = Program.DFS("Burgas", "Silistra", new List<string>()) ;
            //for( int i= neigh.Count-1; i >=0; i--)
            //{
            //    Console.WriteLine(neigh[i]);
            //}


            Program.PrintAllNeighbours("Varna");
            //var paths = Program.FindPath("Burgas", "Razgrad", new List<string>());
            //for (int i = paths.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(paths[i]);
            //}
        }
    }
}

