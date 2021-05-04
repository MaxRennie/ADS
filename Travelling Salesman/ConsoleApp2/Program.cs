using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();

            myGraph.TS();

            Console.ReadLine();
        }


        class Graph
        {

            List<List<Edge>> WeightedGraph = new List<List<Edge>>();

            public Graph()
            {
                int NumberOfNodes = 5;
                WeightedGraph = new List<List<Edge>>(5);

                for (int i = 0; i < NumberOfNodes; i++)
                {
                    WeightedGraph.Add(new List<Edge>());
                }


                WeightedGraph[0].Add(new Edge(1, 98));
                WeightedGraph[0].Add(new Edge(2, 218));
                WeightedGraph[0].Add(new Edge(3, 97));
                WeightedGraph[0].Add(new Edge(4, 94));

                WeightedGraph[1].Add(new Edge(0, 98));
                WeightedGraph[1].Add(new Edge(2, 150));
                WeightedGraph[1].Add(new Edge(3, 164));
                WeightedGraph[1].Add(new Edge(4, 193));

                WeightedGraph[2].Add(new Edge(0, 218));
                WeightedGraph[2].Add(new Edge(1, 150));
                WeightedGraph[2].Add(new Edge(3, 218));
                WeightedGraph[2].Add(new Edge(4, 298));

                WeightedGraph[3].Add(new Edge(0, 97));
                WeightedGraph[3].Add(new Edge(1, 164));
                WeightedGraph[3].Add(new Edge(2, 218));
                WeightedGraph[3].Add(new Edge(4, 102));

                WeightedGraph[4].Add(new Edge(0, 94));
                WeightedGraph[4].Add(new Edge(1, 193));
                WeightedGraph[4].Add(new Edge(2, 298));
                WeightedGraph[4].Add(new Edge(3, 102));

            }
            public void TS()
            {
                List<Edge> ShortestRoute = new List<Edge>();

                Random r = new Random();
                int index = r.Next(0,5);

                List<int> visited = new List<int>();

                for (int i = 0; i < WeightedGraph.Count; i++)
                {
                    List<Edge> Node = WeightedGraph[index];

                    Edge ShortestEdge = Node[0];


                    if (visited.Count == WeightedGraph.Count - 1)
                        break;

                    //find a node we havnt visited
                    while (visited.Contains(ShortestEdge.NodeToConnectTo))
                    {
                        if (Node.IndexOf(ShortestEdge) + 1 >= Node.Count)
                            continue;

                        ShortestEdge = Node[Node.IndexOf(ShortestEdge) + 1];
                    }

                    foreach (Edge edge in Node)
                    {
                        //if (!Visited.Contains( edge.NodeToConnectTo))
                        //{

                        //}
                        if (edge.Weight < ShortestEdge.Weight && !visited.Contains(edge.NodeToConnectTo))
                            ShortestEdge = edge;
                    }

                    ShortestRoute.Add(ShortestEdge);
                    visited.Add(index);
                    index = ShortestEdge.NodeToConnectTo;
                }

                visited.Add(index);
                //ShortestRoute.Add();

                foreach (int i in visited)
                {
                    Console.WriteLine(i);
                }

                //PrintList(ShortestRoute);
            }

            public void PrintList(List<Edge> edges)
            {

                for (int i = 0; i < edges.Count; i++)
                {
                    Console.WriteLine(edges[i].NodeToConnectTo);
                    Console.WriteLine();
                }

            }
            public struct Edge
            {
                public int NodeToConnectTo;
                public int Weight;
                public Edge(int _NodeToConnectTo, int _Weight)
                {
                    Weight = _Weight;
                    NodeToConnectTo = _NodeToConnectTo;
                }
            }
        }

    }
}