using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3singlylinkedlist
{
    class Node
    {
        public int value;//Değeri saklayacak eleman
        public Node next;//Bir sonraki elemana olan referans
        public Node() { }
        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }
    }
}
