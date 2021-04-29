using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TravellingSalesman();
        }

        private static void TravellingSalesman()
        {
            List<List<String>> CityMap = new List<List<String>>();
            CityMap.Add("Oxford");
            CityMap.Add("Leicester");
            CityMap.Add("Liverpool");
            CityMap.Add("Bristol");
            CityMap.Add("Southampton");

            CityMap["Oxford"].Add(new Edge("Leicester", 98));
        }

        private class city
        {
            
        }

        struct Edge
        {
            public int ConnectedCity;
            public int Distance;
            public Edge(int connectedCity, int distance)
            {
                ConnectedCity = this.ConnectedCity
                
            }
        }
    }


}
