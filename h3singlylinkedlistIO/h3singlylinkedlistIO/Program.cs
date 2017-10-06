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
            //bl.print();
            //Console.WriteLine(bl.toplam());
            SinglyLinkedList bl2 = new SinglyLinkedList();
            bl2.addHead(3);
            bl2.addHead(5);
            bl2.addHead(7);
            bl2.print();
            bl2.addTail (9);
            bl2.print ();
            bl2.insertAfter (bl2.getHead (), 15);
            bl2.print ();
            bl2.insertAfter (0, 76);
            bl2.insertAfter (5, 41);
            bl2.addHead (12);
            bl2.print ();

        }
    }
}
