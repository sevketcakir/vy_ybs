using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2myqueueIO
{
    class MyQueue
    {
        int[] dizi;
        int front = -1;
        int rear = -1;
        public MyQueue()
        {
            dizi = new int[20];
        }
        public MyQueue(int boyut)
        {
            dizi = new int[boyut];
        }
        public bool isEmpty()
        {
            return front == -1 && rear == -1;//başlangıç değeri olarak front ve rear değişkenleri -1, her iki değer de -1 ise kuyruk boştur
        }
        public bool isFull()
        {
            return rear == dizi.Length - 1;//Eğer rear değeri dizinin son elemanını gösteriyorsa daha fazla eleman eklenemez(kuyruk doludur)
        }
        public void enqueue(int eleman)//ekleme işlemi yapar
        {
            if (isFull())
                throw new Exception("Kuyruk dolu!!!");
            else if (isEmpty())//eğer boşsa front ve rear'ı 0 yap ve elemanı başa yaz
            {
                front = 0;
                rear = 0;
                dizi[0] = eleman;
            }
            else//Aksi halde rear değerini 1 artırıp yeni elemanı rear'a yerleştir
            {
                rear++;
                dizi[rear] = eleman;
            }
        }
        public int dequeue()
        {
            if (isEmpty())
                throw new Exception("Kuyruk boş!!!");
            int donecek = dizi[front++];//Dönecek olan elemanı bir değişkende sakla
            if (front > rear)//Eğer front>rear ise kuyruk boşalmıştır
            {
                front = -1;
                rear = -1;
            }
            return donecek;//değeri döndür
        }
        public void print()
        {
            Console.WriteLine("Eleman sayısı:{0}", Count);
            if (isEmpty())
                return;//print metodu void olduğu için çıkmak için sadece return kullanmak yeterli
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        public int Count {
            get {
                if (isEmpty())//Eğer kuyruk boşsa eleman sayısı 0'dır
                    return 0;
                return rear - front + 1;
            }
        }

    }
}
