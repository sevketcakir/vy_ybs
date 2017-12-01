using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjacencyList
{
    class Vertex
    {
        string value;//değeri tutar
        List<Edge> edges=new List<Edge>();//Kenar listesi
        public Vertex(string value) {//Kurucu metod
            this.value = value;
        }
        public void addEdge(Vertex to)//Mevcut düğüme bir kenar ekler
        {
            Edge edge = new Edge(this, to);//Mevcut düğümden parametre düğümüne bir kenar oluştur
            edges.Add(edge);//Yeni kenarı mevcut düğümün kenar listesine ekle
        }
        public void print()//Mevcut düğümün değerini ve kenarlarını yazdırır
        {
            Console.Write(this.value + " : ");
            foreach (Edge e in edges)
            {
                Console.Write(e.to.value+" -> ");
            }
            Console.WriteLine();
        }
    }
}
