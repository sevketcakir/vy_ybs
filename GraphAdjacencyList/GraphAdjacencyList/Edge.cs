using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjacencyList
{
    class Edge
    {
        Vertex from;
        public Vertex to;
        public Edge(Vertex from, Vertex to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
