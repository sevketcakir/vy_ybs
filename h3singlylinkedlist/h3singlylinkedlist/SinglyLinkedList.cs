using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3singlylinkedlist
{
    class SinglyLinkedList
    {
        Node head;//İlk düğüm/başlangıç
        public SinglyLinkedList() { }
        public SinglyLinkedList(Node head) {
            this.head = head;
        }
        public void print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write("{0} ", current.value);
                current = current.next;
            }
            Console.WriteLine();
        }
        public int toplam()
        {
            //Toplama kodu yazılacak.
            return -1;
        }
    }
}
