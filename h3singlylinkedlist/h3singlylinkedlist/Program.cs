using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3singlylinkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Node d2 = new Node();
            d2.value = 5;
            Node d1 = new Node(17, d2);
            Node d3 = new Node(8, null);
            d2.next = d3;
            SinglyLinkedList ll = new SinglyLinkedList(d1);
            ll.print();
        }
    }
}
