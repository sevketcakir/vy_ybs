using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3singlylinkedlistIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n2 = new Node();
            n2.value = 5;
            Node n1 = new Node(17, n2);
            Node n3 = new Node(8, null);
            n2.next = n3;
            SinglyLinkedList bl = new SinglyLinkedList(n1);
            bl.print();
        }
    }
}
