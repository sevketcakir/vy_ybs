using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3singlylinkedlistIO
{
    class Node
    {
        public int value;//Değerin saklandığı eleman
        public Node next;//Bir sonraki düğüme olan referans
        public Node() { }//Varsayılan kurucu metod
        public Node(int value, Node next)//Parametre alan kurucu metod
        {
            this.value = value;
            this.next = next;
        }
    }
}
