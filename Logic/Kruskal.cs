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

        //default constructor could initialize a graph with a single vertice and no edges
        //but it won't initialize any vertices -- that should be up to the user
        public Kruskal()
        {
            edges = new List<Edge>();
        }

        public List<Edge> FindMinimumSpanningTree(List<char> vertices, List<Edge> edges)
        {
            throw new NotImplementedException();
        }

    }
}
