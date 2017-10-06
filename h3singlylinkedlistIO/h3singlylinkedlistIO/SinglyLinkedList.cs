using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3singlylinkedlistIO
{
    class SinglyLinkedList
    {
        Node head;//Bağlı listenin ilk elemanı
        public SinglyLinkedList() { }//Varsayılan kurucu metod
        public SinglyLinkedList(Node head)//Başlangıç düğümünü parametre olarak alan kurucu metod
        {
            this.head = head;
        }
        /*
         * Değerleri ekrana yazdırır
         */ 
        public void print()
        {
            Node mevcut = head;//mevcut düğümü başlangıç düğümü olarak belirle
            while (mevcut != null)//mevcut düğüm null değerinden farklı olduğu sürece döngü çalışacak
            {
                Console.Write("{0} ", mevcut.value);//mevcut düğümün değerini ekrana yaz
                mevcut = mevcut.next;//Bir sonraki düğümü mevcut düğüm olarak belirle
            }
            Console.WriteLine();
        }
        /*
         * Tüm elemanların değerlerini toplayıp sonucu geri döndürür
         */ 
        public int toplam()
        {
            int t = 0;//Toplamı saklayan değiişken
            Node mevcut = head;
            while (mevcut != null)
            {
                t += mevcut.value;
                mevcut = mevcut.next;
            }
            return t;
        }

        /*
         * Başa eleman ekler
         */
        public void addHead(int value)
        {
            Node newNode = new Node(value, head);//Yeni düğüm oluştur. bu düğümün sonraki elemanı head olsun
            head = newNode;//yeni head değeri olarak yeni oluşturduğumuz düğümü belirle
        }

        /*
         * Sona eleman ekler
         */
        public void addTail(int value)
        {
            Node mevcut = head;//Başlangıç düğümünden başla
            if (head == null)//Eğer liste boş ise
            {
                head = new Node(value, null);//Başa eleman ekle
                return;//Metoddan çık
            }
            while (mevcut.next != null)//mevcut düğümün sonraki düğümü null olmadığı sürece döngü çalışacak
            {
                mevcut = mevcut.next;//Bir sonraki düğüme geç
            }
            mevcut.next = new Node(value, null);//Son düğümün sonraki değerini yeni düğüm olarak belirle.
        }
        /*
         * Verilen düğümden sonra eleman ekler
         */
        public void insertAfter(Node node, int value)
        {
            Node newNode = new Node(value, node.next);//Yeni düğüm oluştur. Yeni düğümün sonraki değeri node'un sonraki değeri olsun
            node.next = newNode;//node'un sonraki değeri yeni düğüm olsun
        }

        /*
         * Verilen indis değerinden sonra eleman ekler
         */
        public void insertAfter(int index, int value)
        {
            int i = 0;//indis değeri 0'dan başlasın
            Node mevcut = head;//mevcut düğümü başlangıç düğümünden(head) başlasın
            while (i < index)//istenilen indise ulaşana kadar döngü çalışacak
            {
                i++;
                mevcut = mevcut.next;
            }//döngüden çıkıldığında mevcut istenilen indisteki düğümü gösterir
            insertAfter(mevcut, value);//istenilen indisteki düğümden sonra yeni değeri ekle
        }
        /*
         * Başlangıç düğümünü geri döndürür.
         */ 
        public Node getHead()
        {
            return head;
        }
    }
}
