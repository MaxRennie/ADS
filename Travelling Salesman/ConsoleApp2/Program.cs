using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();
            //Console.WriteLine(myGraph.Move(2).Weight);
            //Console.ReadLine();
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

                int index = 0;

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

            //public void TS()
            //{
            //    List<Edge> ShortestRoute = new List<Edge>();
            //    List<int> Visited = new List<int>();
            //    int Index = 0;

            //    for (int i = 0; i < WeightedGraph.Count; i++)
            //    {
            //        List<Edge> Node = WeightedGraph[Index];
            //        Edge ShortestEdge = Node[0];


            //        foreach (Edge edge in Node)
            //        {
            //            if (!Visited.Contains(edge.NodeToConnectTo))
            //            {

            //            }
            //            if (edge.Weight < ShortestEdge.Weight)
            //                ShortestEdge = edge;
            //        }

            //        ShortestRoute.Add(ShortestEdge);
            //        foreach (var Node in WeightedGraph)
            //        {
            //            for (int i = 0; i < Node; i++)
            //            {

            //            }
            //        }
            //        Node.Remove(ShortestEdge);
            //    }








            //for (int i = 0; i < WeightedGraph.Count; i++)
            //{
            //    List<Edge> Node = new List<Edge>(WeightedGraph[Index]);

            //    WeightedGraph[Index] = null;

            //    Edge Shortest = Node[0];
            //    foreach (Edge edge in Node)
            //    {
            //        if(WeightedGraph[edge.NodeToConnectTo] != null)
            //        {
            //            if (edge.Weight < Shortest.Weight)
            //                Shortest = edge;
            //        }
            //        else if (WeightedGraph[Shortest.NodeToConnectTo] == null)
            //        {
            //            //bug!!
            //            int NextEdgeIndex = Node.IndexOf(Shortest) + 1;
            //            if (NextEdgeIndex < Node.Count)
            //            {
            //                Shortest = Node[NextEdgeIndex];
            //            }
            //        }
            //    }
            //ShortestRoute.Add(Shortest);
            //    Index = Shortest.NodeToConnectTo;
            //}



            //List<int> VisitedNodes = new List<int>();
            //List<Edge> ShortestRoute = new List<Edge>();

            //    for (int i = 0; VisitedNodes.Count < WeightedGraph.Count; i++)
            //    {
            //        int j = i % 5;
            //        ShortestRoute.Add(Move(j, VisitedNodes));

            //    }

            //    PrintList(ShortestRoute);
            //}
            //public Edge Move(int index, List<int> visitedNodes)
            //{
            //    Edge EdgeTo  = WeightedGraph[index][0];
            //    for (int i = 0; i < WeightedGraph[index].Count; i++) //establishes base shortestedge
            //    {
            //        if (!visitedNodes.Contains(WeightedGraph[index][i].NodeToConnectTo))
            //        {
            //            ShortestEdge = WeightedGraph[index][i];
            //            break;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    for (int i = 0; i < WeightedGraph[index].Count; i++)
            //    {
            //        if(WeightedGraph[index][i].Weight < ShortestEdge.Weight)
            //        {
            //            ShortestEdge = WeightedGraph[index][i];
            //        }
            //    }
            //    visitedNodes.Add(index);
            //    return ShortestEdge;
            //Edge DefaultEdge = (new Edge(0, 0));
            //Edge ShortestEdge = DefaultEdge;
            //if (index != WeightedGraph.Count - 1) //if index is less than index of weightedgraph

            //    for (int i = 0; i < WeightedGraph[index].Count; i++)
            //    {
            //        if (!visitedNodes.Contains(WeightedGraph[index][i].NodeToConnectTo))
            //        {
            //            if (ShortestEdge.Weight == 0)
            //            {
            //                ShortestEdge = WeightedGraph[index][i];
            //            }
            //            if (WeightedGraph[index][i].Weight < ShortestEdge.Weight)
            //            {//if the weight is less than the shortest weight AND the node has not been visited
            //                ShortestEdge = WeightedGraph[index][i];
            //                visitedNodes.Add(index);
            //            }
            //        }
            //        else
            //        {
            //            continue;
            //        }

            //    }
            //return ShortestEdge;
            //}
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