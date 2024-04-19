using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Kruskal
    {
        public int NumVertices { get; set; }
        public int NumEdges { get; set; }

        List<Edge> edges;
        List<Edge> solvedGraph;
        int totalCost;

        //default constructor could initialize a graph with a single vertice and no edges
        //but it won't initialize any vertices -- that should be up to the user
        public Kruskal()
        {
            edges = new List<Edge>();
            solvedGraph = new List<Edge>();
        }

        public List<Edge> FindMinimumSpanningTree(List<Edge> edges, out int totalCost)
        {
            //sort all edges
            QuickSort(edges, 0, edges.Count - 1);
            totalCost = 0;

            foreach(Edge edge in edges)
            {
                Vertex root1 = edge.Source.GetRoot();
                Vertex root2 = edge.Destination.GetRoot();

                if(root1.Name != root2.Name)
                {
                    totalCost += edge.Weight; //add the edge to the graph
                    Vertex.Join(root1, root2);
                    solvedGraph.Add(edge);
                }
            }

            return solvedGraph;

        }


        //using Quicksort to sort edges by weight efficiently
        private void QuickSort(List<Edge> graph, int left, int right)
        {
            int i = left; //leftmost element in the array
            int j = right; //rightmost element in the array
            int x = graph[((i + j) / 2)].Weight; //selecting a pivot element

            do
            {
                while ((graph[i].Weight < x) && (i < right))
                {
                    i++;
                }
                while ((x < graph[j].Weight) && (j > left))
                {
                    j--;
                }
                if(i<=j) //swap
                {
                    Edge y = graph[i];
                    graph[i] = graph[j];
                    graph[j] = y;
                    i++;
                    j--;
                }

            } while (i <= j);

            if(left < j)
            {
                QuickSort(graph, left, j);
            }
            if(i < right)
            {
                QuickSort(graph, i, right);
            }


        }

    }
}
