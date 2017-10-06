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
            //Kodlar buraya yazılacak...
            return -1;
        }

    }
}
