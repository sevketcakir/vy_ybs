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
            Node current = head;
            int t = 0;
            while (current != null)
            {
                t += current.value;
                current = current.next;
            }
            return t;
        }
        public Node getHead()
        {
            return head;
        }
        public void addHead(int value)
        {
            Node newNode = new Node(value, head);//Yeni oluşturulan düğüm head düğümünü göstersin
            head = newNode;//Yeni başlangıç değerini yeni oluşturulan düğüm olarak belirle
        }
        public void addTail(int value)
        {
            Node newNode = new Node(value, null);//Yeni düğüm
            if (head == null)//Bağlı liste boş ise
            {
                head = newNode;//Başa ekle
                return;//Geri dön
            }
            Node current = head;//Başlangıç düğümü
            while (current.next != null)//Son elemana kadar döngü devam edecek(null olmadan döngü sonlanacak)
            {
                current = current.next;//Mevcut değeri belirle
            }
            //current şu an son elemanı gösteriyor
            current.next = newNode;//son eleman olarak bağlantıyı ekle
        }
        /*
         * Parametre olarak verilen node düğümünden sonra araya bir eleman ekler
         */ 
        public void insertAfter(Node node, int value)
        {
            Node newNode = new Node(value, node.next);//Yeni düğüm oluştur. Yeni düğümün sonraki elemanı parametre olarak gönderilen düğümün sonraki değeri olarak ata.
            node.next = newNode;//düğümün(node) sonraki değerini yeni düğüm olarak belirle
        }
        /*
         * Parametre olarak verilen indisteki düğümünden sonra araya bir eleman ekler
         */
        public void insertAfter(int index, int value)
        {
            int i = 0;//Başlangıç indisi
            Node current = head;//head düğümünden başla
            while (i < index)//parametre olarak verilen indis değerine gelene kadar döngü devam eder
            {
                i++;
                current = current.next;//sonraki elemana geç
            }
            //Döngüden çıktıktan sonra current istenilen indisteki düğümü saklar
            insertAfter(current, value);//Yukardaki insertAfter metodunu çağırarak elemanı araya ekle
        }
    }
}
