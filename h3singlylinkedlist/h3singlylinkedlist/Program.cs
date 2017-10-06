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
            //ll.print();
            //Console.WriteLine(ll.toplam());
            SinglyLinkedList bl2 = new SinglyLinkedList();
            bl2.addHead(3);
            bl2.addHead(5);
            bl2.addHead(7);
            bl2.print();
            bl2.addTail(9);
            bl2.print();
            bl2.insertAfter (bl2.getHead (), 15);
            bl2.print();
            bl2.insertAfter(0, 76);
            bl2.insertAfter(5, 41);
            bl2.addHead(12);
            bl2.print();
        }
    }
}
