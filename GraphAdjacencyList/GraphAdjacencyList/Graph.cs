using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjacencyList
{
    class Graph//Çizge sınıfı
    {
        List<Vertex> vList=new List<Vertex>();//Düğüm listesi
        public void addVertex(Vertex v)//Listeye düğüm ekleyen metod
        {
            vList.Add(v);
        }
        public void print()//Çizgedeki tüm düğümlerin print metodu sırasıyla çağrılır
        {
            foreach (Vertex v in vList)
            {
                v.print();
            }
        }
    }
}
