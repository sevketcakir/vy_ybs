using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjacencyListIO
{
    class Graph
    {
        List<Vertex> vertices = new List<Vertex>();//Düğüm listesi
        public void addVertex(Vertex vertex)//Çizgeye düğüm ekler
        {
            vertices.Add(vertex);
        }
        public void print()
        {
            foreach (Vertex v in vertices)
            {
                v.print();
            }
        }
    }
}
